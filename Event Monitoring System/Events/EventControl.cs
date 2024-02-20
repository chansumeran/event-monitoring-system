using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_Monitoring_System.Events
{
    public partial class EventControl : UserControl
    {
        public EventControl()
        {
            InitializeComponent();
        }

        // Add Event Button
        private void buttonAddEvent_Click(object sender, EventArgs e)
        {
            eventPanel2.Controls.Clear();
            AddEventControl addEvent = new AddEventControl();
            addEvent.Dock = DockStyle.Fill;
            eventPanel2.Controls.Add(addEvent);
        }

        // Show Results Button
        private void buttonShow_Click(object sender, EventArgs e)
        {
            eventPanel2.Controls.Clear();
            ShowParticipantsOfEventControl showParticipants = new ShowParticipantsOfEventControl();
            showParticipants.Dock = DockStyle.Fill;
            eventPanel2.Controls.Add(showParticipants);
        }
    }
}
