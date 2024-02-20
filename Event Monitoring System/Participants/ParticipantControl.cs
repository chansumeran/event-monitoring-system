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
using static Event_Monitoring_System.Dashboard;

namespace Event_Monitoring_System
{
    public partial class ParticipantControl : UserControl
    {

        string connectionString = "server=localhost; port=3306; database=eventmonitoringdb; user=root; password=password;";

        public ParticipantControl()
        {
            InitializeComponent();
        }

        // Add button
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Get all events from the database to be put in the combobox
            List<Event> items = GetDataFromDatabase();

            panel1.Controls.Clear();
            AddParticipantControl addParticipant = new AddParticipantControl();
            addParticipant.Dock = DockStyle.Fill;
            addParticipant.PopulateComboBox(items); // populate the combobox using the items fetched in the db
            panel1.Controls.Add(addParticipant);
        }

        // Method to fetch all events in the database
        public List<Event> GetDataFromDatabase()
        {
            List<Event> items = new List<Event>();

            string query = "SELECT idevents, event_name FROM events";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            items.Add(new Event { Id = reader.GetInt32(0), Name = reader.GetString(1) });
                        }
                    }
                }
            }

            return items;
        }

        // Remove button
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            RemoveParticipantControl removeParticipant = new RemoveParticipantControl(); // Instance of RemoveParticipantControl
            removeParticipant.Dock = DockStyle.Fill;
            removeParticipant.getParticipantsFromDatabase(); // get all participants from db
            panel1.Controls.Add(removeParticipant);
        }
    }
}
