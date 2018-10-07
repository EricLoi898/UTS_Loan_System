﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                MessageBox.Show("Loan Application Submitted");
            }
        }

        private void tbAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);//Prevent users from typing in non-numberic characters
        }
    }
}
