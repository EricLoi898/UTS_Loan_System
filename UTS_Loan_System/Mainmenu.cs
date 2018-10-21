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
    public partial class Mainmenu : Form
    {
        private User user;

        public Mainmenu(User user)
        {
            InitializeComponent();
            this.user = user;
            lbUsername.Text = user.getFullname();
            switch (user.getUsertype())
            {
                case (1)://1 is the usertype id of Student type
                    lbAccess.Text = "Student Access";
                    btnApply.Enabled = btnView.Enabled = true;
                    btnReview.Enabled = false;
                    btnReview.Visible = false;
                    break;
                case (2)://2 is the usertype id of Staff Member type
                    lbAccess.Text = "Staff Member Access";
                    btnApply.Enabled = btnView.Enabled = false;
                    btnApply.Visible = btnView.Visible = false;
                    btnReview.Enabled = true;
                    break;
                case (3)://3 is the usertype id of Staff Manager type
                    lbAccess.Text = "Staff Manager Access";
                    btnApply.Enabled = btnView.Enabled = false;
                    btnApply.Visible = btnView.Visible = false;
                    btnReview.Enabled = true;
                    break;
                default:
                    Console.WriteLine("System error! Please try again!");
                    break;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            ApplyLoan applyLoan = new ApplyLoan(user);
            applyLoan.Show();
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            ReviewApplications reviewApplications = new ReviewApplications(user);
            reviewApplications.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewApplications viewApplications = new ViewApplications(user);
            viewApplications.Show();
        }
    }
}
