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
    public partial class ReviewApplications : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=uts-sep-student-loan-system.database.windows.net;Initial Catalog=uts_sep_student_loan_system;Integrated Security=False;User ID=sepadmin;Password=UTSSTUDENT123@;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");//Create connection to the database
        private User user;
        public ReviewApplications(User user)
        {
            InitializeComponent();
            DataTable dtb = new DataTable();
            try
            {
                user.getAllApplications().Fill(dtb);//Fill the result into a datatable
                dataGridView1.DataSource = dtb;//Bind the datatable result to the datagridview and show it
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Connection to Database failed! Please ensure this device is connected to internet!");//Error Message for database connection
            }
            this.user = user;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            int loanID = Convert.ToInt32(row.Cells[0].Value.ToString().Trim());
            MessageBox.Show("Loan ID [ "+ loanID + " ] is being edited.");
            string query2 = "SELECT * FROM Loans WHERE loanID = '" + loanID + "'; ";//Create a SQL query
            SqlDataAdapter sda = new SqlDataAdapter(query2, sqlcon);//Execute the above SQL query
            DataTable dtb = new DataTable();
            try
            {
                sda.Fill(dtb);//Fill the result into a datatable
                EditApplication editApplication = new EditApplication(dtb, user);
                editApplication.Show();
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Connection to Database failed! Please ensure this device is connected to internet!");//Error Message for database connection
            }
            dtb.Clear();//Clear all of the data in the datatable
            user.getAllApplications().Fill(dtb);//refill a new datatable from the database
            dataGridView1.DataSource = dtb;//Bind the dtb to the dataGridView
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
