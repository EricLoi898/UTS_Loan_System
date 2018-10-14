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

namespace UTS_Loan_System
{
    public partial class ViewApplications : Form
    {
        public ViewApplications()
        {
            InitializeComponent();
            SqlConnection sqlcon = new SqlConnection(@"Data Source=uts-sep-student-loan-system.database.windows.net;Initial Catalog=uts_sep_student_loan_system;Integrated Security=False;User ID=sepadmin;Password=UTSSTUDENT123@;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");//Create connection to the database
            string query = "Select * from Loans;";//Create a SQL query
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);//Execute the above SQL query
            DataTable dtb = new DataTable();
            try
            {
                sda.Fill(dtb);
                dataGridView1.DataSource = dtb;
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Connection to Database failed! Please ensure this device is connected to internet!");
                for (int i = 0; i < 0; i++)
                {
                    dataGridView1.Rows.Add(dtb.Rows[i]);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
