﻿using System;
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
            if (cbbLoantype.Text == "" | tbAmount.Text == "")
            {
                MessageBox.Show("Missing field!");
                return;
            }
            else
            {
                var confirmResult = MessageBox.Show("Are you sure to submit this application??",
                                     "Confirm your submission",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    SqlConnection sqlcon = new SqlConnection(@"Data Source=uts-sep-student-loan-system.database.windows.net;Initial Catalog=uts_sep_student_loan_system;Integrated Security=False;User ID=sepadmin;Password=UTSSTUDENT123@;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                    SqlCommand command = new SqlCommand();
                    command.Connection = sqlcon;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "INSERT INTO Loans(studentID, loantype, amount, status, datetime) VALUES(@studentID, @loantype, @amount, 'submitted', @datetime)";//Create a SQL query 
                    command.Parameters.AddWithValue("@studentID", lbApplicantID.Text);//Add parameters
                    command.Parameters.AddWithValue("@loantype", cbbLoantype.Text.Trim());
                    command.Parameters.AddWithValue("@amount", tbAmount.Text.Trim());
                    command.Parameters.AddWithValue("@datetime", DateTime.Now.ToString());
                    try
                    {
                        sqlcon.Open();//Execute the above SQL query
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Connection to Database failed! Please ensure this device is connected to internet!");
                        return;
                    }
                    MessageBox.Show("Loan Application Submitted");
                    this.Close();
                }
                else
                {
                    return;
                }

            }

        }   
        

        private void tbAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);//Prevent users from typing in non-numberic characters
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AttachDocument attachDocument = new AttachDocument();
            attachDocument.Show();
        }
    }
}
