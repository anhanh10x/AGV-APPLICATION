using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class Account
    {
        //Field 
        private string accountName="";
        private string passWord="";
        private bool isRememberPass = false;
        //Properties
        public string AccountName
        {
            get { return this.accountName; }
            set { this.accountName = value; }
        }
        public string Password
        {
            get { return this.passWord; }
            set { this.passWord = value; }
        }
        public bool IsRememberPass
        {
            get { return this.isRememberPass; }
            set { this.isRememberPass = value; }
        }

        //Constructor
        public Account(string Name = "", string Pass = "", bool State = false)
        {
            this.accountName = Name;
            this.passWord = Pass;
            this.isRememberPass = State;
        }
    }
}
