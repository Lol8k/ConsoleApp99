using DbWrapper.UI;
using DbWrapper.UI.ORM;

namespace ConsoleApp99
{
    public partial class PassangersView : Form
    {
        GridColumn[] columns;
        public DataGridViewAdapter2<Ticket> adapter;

        public PassangersView()
        {
            InitializeComponent();
            CenterToScreen();
            GlobalStyle.Apply(this);
            adapter = new DataGridViewAdapter2<Ticket>(dataGridView1);
            columns =
            [
                new GridColumn("TripId", "Номер рейса",null,Filters.NumberEquals),
                new GridColumn("FirstName", "Имя", firstNameBox),
                new GridColumn("MiddleName", "Отчество", middleNameBox),
                new GridColumn("LastName", "Фамилия", lastNameBox),
            ];
            adapter.SetData(GetList(), columns);
        }

        private List<Ticket> GetList()
        {
            return AppState.GetContext().Set<Ticket>().ToList();
        }

        private void PassangersView_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReturnToTrips();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ReturnToTrips();
        }

        private void ReturnToTrips()
        {
            TripsView tripsView = AppState.Get<TripsView>("trips_view_form");
            tripsView.Show();
            this.Hide();
        }
    }
}
