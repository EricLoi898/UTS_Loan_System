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
        SqlConnection sqlcon = new SqlConnection(@"Data Source=uts-sep-student-loan-system.database.windows.net;Initial Catalog=uts_sep_student_loan_system;Integrated Security=False;User ID=sepadmin;Password=UTSSTUDENT123@;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");//Create connection to the database
        private User user;
        int loan;
        DataTable dtb;

        public ViewApplications(User user)
        {
            InitializeComponent();
            this.user = user;
            dtb = new DataTable();
            try
            {
                user.getApplications().Fill(dtb);
                dataGridView1.DataSource = dtb;//Bind the datatable result to the datagridview and show it
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Connection to Database failed! Please ensure this device is connected to internet!");//Error Message
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this application??",
                                     "Confirm Delete!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                SqlCommand command = new SqlCommand();//Create SQLcommand
                command.Connection = sqlcon;
                command.CommandType = CommandType.Text;
                command.CommandText = "DELETE FROM Loans WHERE loanID = '" + loan + "'; ";//Create a SQL query 
                try
                {
                    sqlcon.Open();//Execute the above SQL query
                    command.ExecuteNonQuery();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Connection to Database failed! Please ensure this device is connected to internet!");//Error Message for database connection
                    return;
                }
                sqlcon.Close();//Close the database connection;
                dtb.Clear();//Clear all of the data in the datatable
                user.getApplications().Fill(dtb);//refill a new datatable from the database
                dataGridView1.DataSource = dtb;//Bind the dtb to the dataGridView
            }
            else
            {
                return;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;//Store the rowindex that is being selected
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            loan = Convert.ToInt32(row.Cells[0].Value.ToString().Trim());//Get the value of the first cell of the row and convert it into string
            MessageBox.Show("Loan ID [ " + loan + " ] is being edited.");
        }
    }
}
