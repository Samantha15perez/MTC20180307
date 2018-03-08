using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//note: remember to slap that last one in

namespace ClassworkSamanthaPerez03072018
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataLoadButton_Click(object sender, EventArgs e)
        {
            try
            {

           
            //Define connection string, see connectionstrings.com for reference
            string connString = @"Server=PL8\MTCDB; Database=Adventureworks2012; Trusted_Connection=True;";

            // Define the connection using the connection string.
            SqlConnection sqlConn = new SqlConnection(connString);

            // Define a data adapter to pull the data from the server using the connection and a stored procedure.
            SqlDataAdapter sqlDA = new SqlDataAdapter("NameRetrieval", sqlConn);

            // Declare an empty data table to hold the data.
            DataTable dtVendors = new DataTable();

            // Fill the data table using the data adapter.
            sqlDA.Fill(dtVendors);

            // Use the data table as the data source for a data grid control.
            theBigBadDataGrid.DataSource = dtVendors;
            }

            catch
            {
                MessageBox.Show("Oops, something went wrong");
            }
        }
    }
}
