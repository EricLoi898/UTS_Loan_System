﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//Import SQL Database

namespace UTS_Loan_System
{
    public partial class Loginpage : Form
    {
        public static int time = 0;
        public Loginpage()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=uts-sep-student-loan-system.database.windows.net;Initial Catalog=uts_sep_student_loan_system;Integrated Security=False;User ID=sepadmin;Password=UTSSTUDENT123@;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");//Create connection to the database
            string query = "Select * from Users Where id = '" + textBox1.Text.Trim() + "' and password = '" + textBox2.Text.Trim() + "'";//Create a SQL query
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);//Execute the above SQL query
            DataTable dtb = new DataTable();
            sda.Fill(dtb);
            if (dtb.Rows.Count == 1)//If a row(user) is found matched in the table
            {
                        Mainmenu mainmenu = new Mainmenu(dtb);//Create a new menu and pass the table with the user details
                        mainmenu.Show();//Show the mainmenu
            }
            else
            {
                MessageBox.Show("Incorrect ID or password! Please try again!");//Warning Message
            };
        }

        private void timer1_Tick(object sender, EventArgs e)
        {           
            time++;
            if(time > 15)//After 15 seconds
            {
                time = 0;
                textBox1.Text = textBox2.Text = "";//Clear the textboxes to protect user privacy
            }
        }
    }
}
