using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication
{
    class UserAccount
    {
        private string FullName;
        protected string UserName;
        protected string UserPassword;

        public UserAccount(string Name, string Uname, string Password)
        {
            this.FullName = Name;
            this.UserName = Uname;
            this.UserPassword = Password;

        }
        public virtual bool ValidatingLogin(string Uname, string Password)
        {
            return true;
        }
        public string getFullName()
        {

            return this.FullName;
        }

    }
}
