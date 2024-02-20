using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Event_Monitoring_System.Dashboard;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Event_Monitoring_System
{

    public partial class AddParticipantControl : UserControl
    {

        string connectionString = "server=localhost; port=3306; database=eventmonitoringdb; user=root; password=password;";

        public AddParticipantControl()
        {
            InitializeComponent();
        }

        // Method to populate combobox by events
        public void PopulateComboBox(List<Event> items)
        {
            string query = "SELECT idevents, event_name FROM events";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                try
                {
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // add the event in the combobox. Value is not displayed in the combobox but is used to reference the id of event.
                            // this is needed for saving participant because idevents is a foreign key in the db
                            comboEvents.Items.Add(new ComboBoxItem
                            {
                                Text = reader["event_name"] != DBNull.Value ? reader["event_name"].ToString() : string.Empty,
                                Value = reader["idevents"]
                            });
                        }
                    }

                    comboEvents.DisplayMember = "Text";
                    comboEvents.ValueMember = "Value";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
        public class ComboBoxItem
        {
            public string Text { get; set; } = "";
            public object Value { get; set; } = "";
        }

        // Save participant
        private void btnSaveParticipant_Click(object sender, EventArgs e)
        {
            if (comboEvents.SelectedItem is ComboBoxItem selectedEvent)
            {
                // Retrieve the text from the textboxes
                string fullName = txtFirstName.Text + " " + txtLastName.Text; // concatenate firstname and lastname
                int age = int.Parse(txtAge.Text); // Convert Age to int
                string course = txtCourse.Text; 
                string yearLevel = txtYearLevel.Text; 

                // Retrieve the selected event ID
                // dito nagamit yung id ng event para ma-save sa db
                int eventId = Convert.ToInt32(selectedEvent.Value);

                // Save all the form data to the database
                SaveFormDataToDatabase(fullName, age, course, yearLevel, eventId);
            }
            else
            {
                MessageBox.Show("Please select an event.");
            }
        }

        // Clear all controls
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFormControls();
        }

        // Helper method to save data to the db
        private void SaveFormDataToDatabase(string fullName, int age, string course, string yearLevel, int eventId)
        {
            // parameterized query
            string query = @"
        INSERT INTO participants (full_name, age, course, year_level, event_id) 
        VALUES (@FullName, @Age, @Course, @YearLevel, @EventId)";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                // Add parameters to prevent SQL injection
                cmd.Parameters.AddWithValue("@FullName", fullName);
                cmd.Parameters.AddWithValue("@Age", age);
                cmd.Parameters.AddWithValue("@Course", course);
                cmd.Parameters.AddWithValue("@YearLevel", yearLevel);
                cmd.Parameters.AddWithValue("@EventId", eventId);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data saved successfully.");
                    ClearFormControls();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        // helper method to clear all controls
        private void ClearFormControls()
        {
            // Clear the textboxes
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAge.Clear();
            txtCourse.Clear();
            txtYearLevel.Clear();

            // Reset the ComboBox selection
            comboEvents.Text = "Pick an event";
        }
    }
}
