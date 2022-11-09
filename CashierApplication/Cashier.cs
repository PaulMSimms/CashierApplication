using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashierApplication
{
    class Cashier : UserAccount
    {
        private string Department;

        public Cashier(string Name, string Department, string Uname, string Password) : base(Name, Uname, Password)
        {
            this.Department = Department;
        }
        public override bool ValidatingLogin(string Uname, string Password)
        {

            if (Uname == UserName && Password == UserPassword)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string getDepartent()
        {
            return this.Department;
        }
    }
}
