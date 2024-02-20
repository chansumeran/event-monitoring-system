using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Monitoring_System.Events
{
    public partial class RemoveEventControl : UserControl
    {
        public RemoveEventControl()
        {
            InitializeComponent();
            PopulateComboBox();
        }

        // Connection string for connecting to the MySQL database.
        string connectionString = "server=localhost; port=3306; database=eventmonitoringdb; user=root; password=password;";

        private void PopulateComboBox()
        {
            string query = "SELECT idevents, event_name FROM events"; 

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    comboBoxEvents.DisplayMember = "Text";
                    comboBoxEvents.ValueMember = "Value";

                    while (reader.Read())
                    {
                        comboBoxEvents.Items.Add(new { Text = reader["event_name"].ToString(), Value = reader["idevents"] });
                    }

                    con.Close();
                }
                catch (Exception ex)
                {
                    // Handle any errors
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (comboBoxEvents.SelectedItem == null)
            {
                MessageBox.Show("Please select an event to delete.");
                return;
            }

            var selectedEvent = (dynamic)comboBoxEvents.SelectedItem;
            int eventId = selectedEvent.Value;

            string query = "DELETE FROM events WHERE idevents = @EventId";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@EventId", eventId);
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Event deleted successfully.");
                        comboBoxEvents.Items.Remove(comboBoxEvents.SelectedItem); // Remove from ComboBox
                    }
                    else
                    {
                        MessageBox.Show("Event not found.");
                    }

                    con.Close();
                }
                catch (Exception ex)
                {
                    // Handle any errors
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
