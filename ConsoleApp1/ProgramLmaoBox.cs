
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ProgramLmaoBox
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            var account = new BankAccount("Sven", 1200);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with an initial balance of ${account.Balance}.");

            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine(account.Balance);

            account.MakeDeposit(100, DateTime.Now, "Friend lost a bet");
            Console.WriteLine(account.Balance);
            /*
            try
            {
                var invalidAcc = new BankAccount("invalid", -3);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
            }

            try
            {
                account.MakeWithdrawal(1000, DateTime.Now, "RTX 2080");  
            }
            catch(InvalidOperationException e)
            {
                Console.WriteLine("\nException caught trying to overdraw\n");
                Console.WriteLine(e.ToString());
            }*/

            Console.WriteLine(account.GetAccountHistory());




            Console.ReadLine();
        }
            
    }
}

