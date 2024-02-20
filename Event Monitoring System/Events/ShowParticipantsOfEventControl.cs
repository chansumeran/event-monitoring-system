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
    // This UserControl is designed to display participants of a specific event.
    public partial class ShowParticipantsOfEventControl : UserControl
    {
        public ShowParticipantsOfEventControl()
        {
            // Initialize the component's UI elements.
            InitializeComponent();
        }

        // Connection string for connecting to the MySQL database.
        string connectionString = "server=localhost; port=3306; database=eventmonitoringdb; user=root; password=password;";

        // This method is called when the UserControl is loaded.
        private void ShowParticipantsOfEventControl_Load(object sender, EventArgs e)
        {
            // Load available events into the combo box.
            LoadEventsIntoComboBox();
        }

        // Loads event names and their IDs into the comboBoxEvents.
        private void LoadEventsIntoComboBox()
        {
            // Establish a connection to the database using the connection string.
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    // Open the database connection.
                    conn.Open();
                    // Prepare a command to fetch event IDs and names.
                    MySqlCommand cmd = new MySqlCommand("SELECT idevents, event_name FROM events", conn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    // Execute the command and fill the DataTable with event data.
                    da.Fill(dt);

                    // Bind the DataTable to the comboBoxEvents.
                    comboBoxEvents.DisplayMember = "event_name"; // Text to display.
                    comboBoxEvents.ValueMember = "idevents"; // Corresponding value.
                    comboBoxEvents.DataSource = dt; // Set the data source to our DataTable.
                }
                catch (Exception ex)
                {
                    // If an error occurs, display a message box with the error message.
                    MessageBox.Show("Error loading events: " + ex.Message);
                }
            }
        }

        // Event handler for when a different event is selected in the combo box.
        private void comboBoxEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ensure a valid selection is made before attempting to load participants.
            if (comboBoxEvents.SelectedValue != null)
            {
                // Load participants for the selected event.
                LoadParticipantsForEvent((int)comboBoxEvents.SelectedValue);
            }
        }

        // Loads participants for a specific event and displays them in a DataGridView.
        private void LoadParticipantsForEvent(int eventId)
        {
            // Establish a new connection to the database.
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    // Open the connection to the database.
                    conn.Open();
                    // Prepare a command to fetch participants for the selected event.
                    MySqlCommand cmd = new MySqlCommand("SELECT full_name, age, course, year_level FROM Participants WHERE event_id = @EventId", conn);
                    // Add the event ID as a parameter to the command to prevent SQL injection.
                    cmd.Parameters.AddWithValue("@EventId", eventId);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    // Execute the command and fill the DataTable with participant data.
                    da.Fill(dt);

                    // Bind the DataTable to the dataGridViewParticipantsOfEvent to display the data.
                    dataGridViewParticipantsOfEvent.DataSource = dt;
                }
                catch (Exception ex)
                {
                    // If an error occurs, display a message box with the error message.
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
