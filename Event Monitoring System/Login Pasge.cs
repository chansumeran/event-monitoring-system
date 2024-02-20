using MySql.Data.MySqlClient;

namespace Event_Monitoring_System
{
    public partial class loginPage : Form
    {
        string connectionString = "server=localhost;port=3306;database=eventmonitoringdb;user=root;password=password";
        bool loginSuccessful =false;

        public loginPage()
        {
            InitializeComponent();
        }

        // connect to database when page loads
        private void loginPage_Load(object sender, EventArgs e)
        {
            
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Welcome to Event Monitoring System!", "Greetings", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Login button
        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    // sql parameterized query to avoid sql injection
                    string query = "SELECT COUNT(1) FROM users WHERE username=@username AND password=@password"; 

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        // inject the values to MySqlCommand
                        command.Parameters.AddWithValue("@username", txtUsername.Text);
                        command.Parameters.AddWithValue("@password", txtPassword.Text);

                        loginSuccessful = Convert.ToInt32(command.ExecuteScalar()) == 1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (loginSuccessful)
            {
                Dashboard mainForm = new Dashboard();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed. Please check your username and password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
