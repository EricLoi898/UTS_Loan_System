using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace UTS_Loan_System
{
    public class User
    {
        private SqlConnection sqlcon = new SqlConnection(@"Data Source=uts-sep-student-loan-system.database.windows.net;Initial Catalog=uts_sep_student_loan_system;Integrated Security=False;User ID=sepadmin;Password=UTSSTUDENT123@;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");//Create connection to the database;
        private int id, usertype;
        private string password, firstname, lastname;

        public User(int id, string password, string firstname, string lastname, int usertype) {            
            this.id = id;
            this.password = password;
            this.firstname = firstname;
            this.lastname = lastname;
            this.usertype = usertype;
        }

        public int getID()
        {
            return id;
        }

        public string getFirstname()
        {
            return firstname;
        }

        public string getFullname()
        {
            return firstname + ", " + lastname;
        }

        public int getUsertype()
        {
            return usertype;
        }
        public SqlDataAdapter getApplications()
        {
            string query = "SELECT loanID, loantype, amount, status, datetime FROM Loans WHERE studentID = '" + id + "'; ";//Create a SQL query
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);//Execute the above SQL query
            return sda;   
        }

        public SqlDataAdapter getAllApplications()
        {
            string query = "SELECT * FROM Loans;";//Create a SQL query
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);//Execute the above SQL query
            return sda;
        }
    }
}
