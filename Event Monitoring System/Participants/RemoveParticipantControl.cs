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

namespace Event_Monitoring_System
{
    public partial class RemoveParticipantControl : UserControl
    {
        public RemoveParticipantControl()
        {
            InitializeComponent();
        }

        string connectionString = "server=localhost; port=3306; database=eventmonitoringdb; user=root; password=password";

        // Method to get all participants in the database
        public void getParticipantsFromDatabase()
        {

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    string query = "SELECT id, full_name, age, course, year_level, event_id FROM participants";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);

                    // store the result in a DataTable
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // display the reslt in a datagridview
                    dataGridViewRemoveParticipants.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // Remove Button
        public void buttonRemoveParticipant_Click(object sender, EventArgs e)
        {
            if (dataGridViewRemoveParticipants.SelectedRows.Count > 0)
            {
                // Assuming your ID column is the first column in the DataGridView
                int selectedIndex = dataGridViewRemoveParticipants.SelectedRows[0].Index;
                int id = Convert.ToInt32(dataGridViewRemoveParticipants[0, selectedIndex].Value); // Get the ID of the selected row

                string query = "DELETE FROM Participants WHERE ID = @ID";

                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ID", id);
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        con.Close();

                        if (rowsAffected > 0)
                        {
                            // Successfully deleted the row from the database, refresh the DataGridView
                            MessageBox.Show("Participant deleted successfully.");
                            getParticipantsFromDatabase();
                        }
                        else
                        {
                            MessageBox.Show("Deletion failed.");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }
    }
}
