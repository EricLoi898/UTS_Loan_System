using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTS_Loan_System
{
    public class Loan
    {
        private int loanID, userID, amount;
        private string loanType;

        public Loan(int loanID, int userID, int amount, string loanType)
        {
            this.loanID = loanID;
            this.userID = userID;
            this.amount = amount;
            this.loanType = loanType;
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
            get;set;
        }
        public string getLoanType()
        {
            return loanType;
        }
    }
}
