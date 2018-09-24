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
        private DataTable dtb1;

        public Mainmenu(DataTable dtb)
        {
            InitializeComponent();
            label1.Text = dtb.Rows[0][2].ToString().Trim() + ", " + dtb.Rows[0][3].ToString().Trim();
            switch (dtb.Rows[0][4].ToString().Trim())
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
            dtb1 = dtb;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            ApplyLoan applyLoan = new ApplyLoan(dtb1);
            applyLoan.Show();
        }
    }
}
