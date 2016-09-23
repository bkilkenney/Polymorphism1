using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism1
{
    class AccountHolder
    {
        private string accountHolderName = "Scrooge McDuck";
        private int accountNumber = 8675309;
        private bool AdminPermission = true; 

              
        public virtual void Deposit()
        {
            Deposit();  //This part of the method can be called from the base class, it doesn't need to be overwritten
        }
        public virtual void Withdraw()
        {
            Withdraw(); 
        }
    }
}
