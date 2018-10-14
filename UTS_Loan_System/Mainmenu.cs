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
        //private DataTable dtb1;
        private User user;

        public Mainmenu(User loggedUser)
        {
            InitializeComponent();
            user = loggedUser;
            label1.Text = loggedUser.getFullname();
            switch (loggedUser.getUsertype())
            {
                case ("Student"):
                    MessageBox.Show("Student");
                    btnApply.Enabled = btnView.Enabled = true;
                    btnReview.Enabled = false;
                    btnReview.Visible = false;
                    break;
                case ("Staff Member"):
                    MessageBox.Show("Staff Member");
                    btnApply.Enabled = btnView.Enabled = false;
                    btnApply.Visible = btnView.Visible = false;
                    btnReview.Enabled = true;
                    break;
                case ("Staff Manager"):
                    MessageBox.Show("Staff Manager");
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
            ReviewApplications reviewApplications = new ReviewApplications();
            reviewApplications.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {

        }
    }
}
