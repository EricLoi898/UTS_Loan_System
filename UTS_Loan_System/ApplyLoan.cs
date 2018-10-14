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
    public partial class ApplyLoan : Form
    {
        public ApplyLoan(User loggedUser)
        {
            InitializeComponent();
            lbApplicantID.Text = Convert.ToString(loggedUser.getID());//Show student details in the page.
            lbApplicantfirstname.Text = loggedUser.getFirstname();
            lbApplicantlastname.Text = loggedUser.getFullname();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(cbbLoantype.Text == "" | tbAmount.Text == "")
            {
                MessageBox.Show("Missing field!");
                MessageBox.Show(Convert.ToString(tbAmount.Text.GetType()));
            }
            else{
                using (SqlConnection connection = new SqlConnection(@"Data Source=uts-sep-student-loan-system.database.windows.net;Initial Catalog=uts_sep_student_loan_system;Integrated Security=False;User ID=sepadmin;Password=UTSSTUDENT123@;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandType = CommandType.Text;
                        command.CommandText = "INSERT INTO Loans(studentID, loantype, amount) VALUES(@studentID, @loantype, @amount)";//Create a SQL query 
                        command.Parameters.AddWithValue("@studentID", lbApplicantID.Text);
                        command.Parameters.AddWithValue("@loantype", cbbLoantype.Text.Trim());
                        command.Parameters.AddWithValue("@amount", tbAmount.Text.Trim());

                        try
                        {
                            connection.Open();//Execute the above SQL query
                            command.ExecuteNonQuery();
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("Connection to Database failed! Please ensure this device is connected to internet!");
                        }
                        MessageBox.Show("Loan Application Submitted");
                    }
                }
            }
        }

        private void tbAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);//Prevent users from typing in non-numberic characters
        }
    }
}
