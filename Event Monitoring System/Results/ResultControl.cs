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

namespace Event_Monitoring_System.Results
{
    public partial class ResultControl : UserControl
    {
        public ResultControl()
        {
            InitializeComponent();
        }

        string connectionString = "server=localhost; port=3306; database=eventmonitoringdb; user=root; password=password;";

        public void LoadEvents()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string query = "SELECT event_name FROM events ORDER BY event_name";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Add a "Place" column to your DataTable
                    dt.Columns.Add("Place", typeof(string));

                    dataGridViewResults.DataSource = dt;

                    // Make the DataGridView show a textbox for editing "Place"
                    dataGridViewResults.Columns["Place"].ReadOnly = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading events: " + ex.Message);
                }
            }
        }
    }
}
