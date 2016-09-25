using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism1
{
    class ReserveAccount : AccountHolder
    {
        protected static int depositCount = 0;
        protected static int withdrawlCount = 0;

        public ReserveAccount(decimal balance) : base(balance)
        {
        }

        public decimal ReserveAccountBalance { get; set; }



        public override void Deposit()
        {
            Deposit();
            depositCount++;
        }
        public override void Withdrawl()
        {
            Withdrawl();
            withdrawlCount++;
        }
    }
}
