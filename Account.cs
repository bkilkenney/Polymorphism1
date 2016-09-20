using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism1
{
    class Account
    {
        public virtual void Deposit()
        {
            Console.WriteLine("We added some money");
        }
        public virtual void Withdraw()
        {
            Console.WriteLine("We took out some money");
        }
    }
}
