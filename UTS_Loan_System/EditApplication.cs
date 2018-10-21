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
    public partial class EditApplication : Form
    {
        private SqlConnection sqlcon = new SqlConnection(@"Data Source=uts-sep-student-loan-system.database.windows.net;Initial Catalog=uts_sep_student_loan_system;Integrated Security=False;User ID=sepadmin;Password=UTSSTUDENT123@;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");//Create connection to the database;
        private Loan loan;
        private DataTable dtb;
        private User user;
        public EditApplication(DataTable dtb, User user)
        {
            InitializeComponent();
            this.dtb = dtb;
            this.user = user;
            if (user.getUsertype() == 2)
            {
                cbStatus.Enabled = false;
            }
            else {
                tbComment.ReadOnly = true;
            }

            string a1 = tbLoanID.Text = dtb.Rows[0][0].ToString().Trim();//Show the application details on screen
            string a2 = tbApplicantID.Text = dtb.Rows[0][1].ToString().Trim();
            string a3 = tbLoantype.Text = dtb.Rows[0][2].ToString().Trim();
            string a4 = tbAmount.Text = dtb.Rows[0][3].ToString().Trim();
            string a5 = tbComment.Text = dtb.Rows[0][4].ToString().Trim();
            cbStatus.Text = dtb.Rows[0][5].ToString().Trim();
            loan = new Loan(Convert.ToInt32(a1), Convert.ToInt32(a2), Convert.ToInt32(a4), a3, a5);//Create a new loan application object

            string query = "Select firstname, lastname from Users Where id = '" + tbApplicantID.Text.Trim() + "'";//Create a SQL query to get the name of the user
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);//Execute the above SQL query
            DataTable dtbname = new DataTable();
            try
            {
                sda.Fill(dtbname);
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Connection to Database failed! Please ensure this device is connected to internet!");
            }

            tbFirstname.Text = dtbname.Rows[0][0].ToString().Trim();//Since the name of the student is not stored in the application, we need to do a query to get its name
            tbLastname.Text = dtbname.Rows[0][1].ToString().Trim();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();//Create SQLcommand
            command.Connection = sqlcon;
            command.CommandText = "UPDATE Loans SET comment = '"+ tbComment.Text +"', status = '"+ cbStatus.Text +"' WHERE loanID = '" + tbLoanID.Text + "'; ";//Create a SQL query 
            //SqlCommand command = loan.writeComments(Convert.ToInt32(tbLoanID.Text), textBox1.Text);
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
            //dataGridView1.DataSource = null;//Refresh the datagridview after the deleting a row
            sqlcon.Close();//Close the database connection;
            MessageBox.Show("Successfully edited");//Successful Message
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
