using DbWrapper.UI;
using DbWrapper.UI.ORM;
using System.Data;

namespace ConsoleApp99
{
    public partial class TripsView : Form
    {
        GridColumn[] columns;
        DataGridViewAdapter2<Trip> adapter;

        public TripsView()
        {
            InitializeComponent();
            CenterToScreen();
            GlobalStyle.Apply(this);
            string role = AppState.Get<string>("role");
            if (role.Equals("Пользователь"))
            {
                adminPanel.Visible = false;
                viewPassangers.Visible = false;
            }
            adapter = new DataGridViewAdapter2<Trip>(dataGridView1);

            columns =
            [
                new GridColumn("Id", "Номер"),
                new GridColumn("CompanyName", "Компания", null, Filters.StringMatch),
                new GridColumn("TownFrom", "Из города", fromTownBox),
                new GridColumn("TownTo", "В город", toTownBox),
                new GridColumn("TimeOut", "Отправление", timeOutBox),
                new GridColumn("TimeIn", "Прибытие", timeInBox),
                new GridColumn("Capacity", "Вместимость"),
                new GridColumn("PassangerCount", "Пассажиры")
            ];
            adapter.SetData(GetList(), columns);
            SetCompanies();
        }

        private List<Trip> GetList()
        {
            var tickets = AppState.GetContext().Set<Ticket>().ToList();
            var trips = AppState.GetContext().Set<Trip>().ToList().OrderBy(trip => trip.TimeOut).ToList();
            trips.ForEach(trip =>
            {
                int count = tickets.Count(ticket => ticket.TripId == trip.Id);
                if (trip.Capacity > 0)
                {
                    double percentage = ((double)count / trip.Capacity) * 100;
                    trip.PassangerCount = $"{Math.Round(percentage, 1)}%    {count}/{trip.Capacity}";
                }
                else
                {
                    trip.PassangerCount = $"0%    {count}/0";
                }
            });
            return trips;
        }

        private void SetCompanies()
        {
            companyBox.DropDownStyle = ComboBoxStyle.DropDownList;
            companyBox.Items.Add("(Не выбрано)");
            var companies = AppState.GetContext().Set<Company>().ToList();
            companies.ForEach(company => companyBox.Items.Add(company.Name));
            companyBox.SelectedIndex = 0;

            companyBox.SelectedIndexChanged += (sender, e) =>
            {
                int index = companyBox.SelectedIndex;
                string filterText = string.Empty;
                if (index > 0)
                {
                    filterText = companyBox.SelectedItem.ToString();
                }
                adapter.SetFilterValue("CompanyName", filterText);
            };
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            using (var form = new EntityEditor<Trip>(columns, null))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    adapter.UpdateData(GetList());
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var rows = adapter.GetSelectedRows();
            if (rows.Count() == 1)
            {
                var row = rows.First();
                using (var form = new EntityEditor<Trip>(columns, row))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        adapter.UpdateData(GetList());
                    }
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var rows = adapter.GetSelectedRows();
            if (rows.Count() > 0)
            {
                var set = AppState.GetContext().Set<Trip>();
                foreach (var row in rows)
                {
                    set.Remove(row);
                }
                adapter.UpdateData(GetList());
            }
        }

        private void TripsView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AuthForm authForm = AppState.Get<AuthForm>("auth_form");
            authForm.Show();
            this.Hide();
        }

        private void viewPassangers_Click(object sender, EventArgs e)
        {
            var rows = adapter.GetSelectedRows();
            if (rows.Count() == 1)
            {
                var row = rows.First();
                PassangersView passangersView = new PassangersView();
                passangersView.adapter.SetFilterValue("TripId", row.Id.ToString());
                passangersView.Show();
                this.Hide();
            }
        }
    }
}
