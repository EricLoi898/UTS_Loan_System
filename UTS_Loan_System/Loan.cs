using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace UTS_Loan_System
{
    public class Loan
    {
        private SqlConnection sqlcon = new SqlConnection(@"Data Source=uts-sep-student-loan-system.database.windows.net;Initial Catalog=uts_sep_student_loan_system;Integrated Security=False;User ID=sepadmin;Password=UTSSTUDENT123@;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");//Create connection to the database;
        private int loanID, userID, amount;
        private string loanType, comment;

        public Loan(int loanID, int userID, int amount, string loanType, string comment)
        {
            this.loanID = loanID;
            this.userID = userID;
            this.amount = amount;
            this.loanType = loanType;
            this.comment = comment;
        }

        public int getLoanID()
        {
            return loanID;
        }

        public int getUserID()
        {
            return userID;
        }

        public int Amount
        {
            get; set;
        }
        public string getLoanType()
        {
            return loanType;
        }
        public SqlCommand writeComments(int loan, string comment)
        {
            SqlCommand command = new SqlCommand();//Create SQLcommand
            command.Connection = sqlcon;
            command.CommandText = "UPDATE Loans SET comment = '" + comment + "' WHERE loanID = '" + loan + "'; ";//Create a SQL query 
            return command;
        }

        /*public string getFirstname(int id)
        {
            sqlcon.Open();//Open new connection
            SqlCommand command = new SqlCommand("Select firstname from Users Where id = '" + id + "'");//Create a SQL query
            try
            {
                string firstname = Convert.ToString(command.ExecuteScalar());
                return firstname;
            }
            catch (System.Data.SqlClient.SqlException)
            {
                Console.WriteLine("Connection to Database failed! Please ensure this device is connected to internet!");
                return null;
            }
        }*/
    }    
}
