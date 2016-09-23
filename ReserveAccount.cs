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
        protected static int withdrawCount = 0;
        

        public override void Deposit()
        {
            Deposit();  
        }
        public override void Withdraw()
        {
            Withdraw();
        }
    }
}
