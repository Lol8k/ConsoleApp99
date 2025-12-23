using DbWrapper.UI.ORM;

namespace ConsoleApp99
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
            CenterToScreen();
            GlobalStyle.Apply(this);
            AppState.Set("auth_form", this);
            roleBox.DropDownStyle = ComboBoxStyle.DropDownList;
            roleBox.Items.Add("Пользователь");
            roleBox.Items.Add("Администратор");
            roleBox.SelectedIndex = 0;
            errorBox.Text = string.Empty;
        }

        private void authButton_Click(object sender, EventArgs e)
        {
            errorBox.Text = string.Empty;
            if (string.IsNullOrEmpty(loginBox.Text))
            {
                errorBox.ForeColor = Color.Red;
                errorBox.Text = "Поле 'Логин' не может быть пустым";
                return;
            }
            if (string.IsNullOrEmpty(passwordBox.Text))
            {
                errorBox.ForeColor = Color.Red;
                errorBox.Text = "Поле 'Пароль' не может быть пустым";
                return;
            }
            if (loginBox.Text.Equals("root") && passwordBox.Text.Equals("root"))
            {
                errorBox.ForeColor = Color.Green;
                errorBox.Text = "Успешно";
                AppState.Set("role", roleBox.SelectedItem.ToString());
                TripsView tripsView = new TripsView();
                AppState.Set("trips_view_form", tripsView);
                tripsView.Show();
                this.Hide();
            }
            else
            {
                errorBox.ForeColor = Color.Red;
                errorBox.Text = "Пользователь не найден";
                return;
            }
        }
    }
}
