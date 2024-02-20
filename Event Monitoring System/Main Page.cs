using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;
using Event_Monitoring_System.Events;
using Event_Monitoring_System.Results;

namespace Event_Monitoring_System
{
    public partial class Dashboard : Form
    {

        public Dashboard()
        {
            InitializeComponent();
        }

        // Events Panel
        private void buttonEvents_Click(object sender, EventArgs e)
        {
            dashboardContainer.Panel2.Controls.Clear();
            EventControl eventControl = new EventControl();
            eventControl.Dock = DockStyle.Fill;
            dashboardContainer.Panel2.Controls.Add(eventControl); // add all controls of eventControl to dashboard
        }

        // Participants Panel
        private void buttonParticipants_Click(object sender, EventArgs e)
        {
            dashboardContainer.Panel2.Controls.Clear();
            ParticipantControl participantControl = new ParticipantControl();
            participantControl.Dock = DockStyle.Fill;
            dashboardContainer.Panel2.Controls.Add(participantControl); // add all controls of participantsControl to dashboard
        }

        public class Event
        {
            public int Id { get; set; }
            public string Name { get; set; }

            // Override ToString to display the item in the ComboBox correctly
            public override string ToString()
            {
                return Name;
            }
        }

        private ResultControl resultControlInstance;
        // Method to preserve the edited places of events
        private void ShowResultControl()
        {
            // create a new instance of ResultControl if it is null
            if (resultControlInstance == null)
            {
                resultControlInstance = new ResultControl();
                resultControlInstance.LoadEvents(); // Load events once
            }

            // otherwise, preserve it
            dashboardContainer.Panel2.Controls.Clear();
            dashboardContainer.Panel2.Controls.Add(resultControlInstance);
            resultControlInstance.Dock = DockStyle.Fill;
        }

        // Results Panel
        private void buttonEditResults_Click(object sender, EventArgs e)
        {
            ShowResultControl();
        }
    }
}
