using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism1
{
    class Program
    {
        private static object accountHolderName;

        static void Main(string[] args)
        {
            CheckingAccount check = new int checkingAccountNumber(int 1357976); //Trying to create an object

            

            
                      
            MainMenu();  //Calling the main menu from method below

        }

//Menu items:
//view client info
//view balance (checking, reserve, savings)
//option to deposit funds
//option to withdraw funds


     //Methods:
        public static void MainMenu()  //Method for the main menu
        {
            Console.WriteLine("Welcome back Mr. McDuck, what would you like to do today?");
            Console.WriteLine("1. Make a Deposit");
            Console.WriteLine("2. Withdraw Funds");
            Console.WriteLine("3. View Account Balances");
            Console.WriteLine("4. Exit");

            string response = Console.ReadLine();
           
            
        }
    }
}


