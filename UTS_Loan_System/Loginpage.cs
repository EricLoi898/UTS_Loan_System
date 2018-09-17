using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//SQL Database

namespace UTS_Loan_System
{
    public partial class Loginpage : Form
    {
        public Loginpage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Anthony\source\repos\UTS_Loan_System\Database\Database.mdf;Integrated Security=True;Connect Timeout=30");
            string query = "Select * from Users Where id = '" + textBox1.Text.Trim() + "' and password = '" + textBox2.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtb = new DataTable();
            sda.Fill(dtb);
            if (dtb.Rows.Count == 1)
            {
                Mainmenu mainmenu = new Mainmenu(dtb);
                mainmenu.Show();
            }
            else
            {
                MessageBox.Show("Incorrect ID or password! Please try again!");
            };
        }
    }
}
