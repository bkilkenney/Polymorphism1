﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism1
{
    class CheckingAccount : AccountHolder   //CHECKINGACCOUNT & SAVINGS are derived classes.  ACCOUNT is the base class
    {
        protected static int depositCount = 0;
        protected static int withdrawCount = 0;

        public override void Deposit()
        {
            base.Deposit();  //This part of the method can be called from the base class, it doesn't need to be overwritten
        }
        public override void Withdraw()
        {

        }
    }
}
