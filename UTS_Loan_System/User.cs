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
        private int id;
        private string password, firstname, lastname, usertype;

        public User(int id, string password, string firstname, string lastname, string usertype) {            
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

        public string getUsertype()
        {
            return usertype;
        }
    }
}
