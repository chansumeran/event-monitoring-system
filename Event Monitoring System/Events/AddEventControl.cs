using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Event_Monitoring_System.Events
{
    // Defines a UserControl for adding events to the event monitoring system.
    public partial class AddEventControl : UserControl
    {
        // Constructor for the AddEventControl.
        public AddEventControl()
        {
            // Initialize the control's components.
            InitializeComponent();
        }

        // Connection string for connecting to the MySQL database.
        string connectionString = "server=localhost; port=3306; database=eventmonitoringdb; user=root; password=password;";

        // Event handler for the "Save Event" button click.
        private void buttonSaveEvent_Click(object sender, EventArgs e)
        {
            // SQL query to insert a new event into the 'events' table.
            string query = "INSERT INTO events (event_name) VALUES (@event_name)";

            // Using statement to ensure the connection is closed and disposed properly.
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                // Open the database connection.
                conn.Open();

                // Using statement for the MySqlCommand to ensure it's disposed properly.
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // Use parameters to prevent SQL injection.
                    cmd.Parameters.AddWithValue("@event_name", txtEventName.Text);

                    // Execute the insert command.
                    cmd.ExecuteNonQuery();
                }
            }

            // Clear the textbox after saving the event to the database.
            txtEventName.Text = string.Empty;
            // Show a message box to inform the user that data was saved successfully.
            MessageBox.Show("Data saved successfully!");
        }
    }
}
