using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank("Coders Bank", 10);
            for (int i = 0; i < 10; i++)
            {
                bank.AddAccount(new Account("nayeem", 2000, new Address("20", "10", "Dhaka", "Bangladesh")));
                bank.AddAccount(new Account("Johnny", 3000, new Address("40", "30", "Chittagong", "Bangladesh")));
                bank.AddAccount(new Account("John", 4000, new Address("40", "30", "Sylhet", "Bangladesh")));
               
            }

            Console.WriteLine("   \n ");

            Console.WriteLine("Welcome to the " + bank.BankName);

            Console.WriteLine("Choose from the Below Option");
            Console.WriteLine("1. Create an Account");
            Console.WriteLine("2. Withdraw Balance");
            Console.WriteLine("3. Deposit Balance");
            Console.WriteLine("4. Transfer Balance");
            Console.WriteLine("5. Delete Account");
            Console.WriteLine("6. Show Account Details ");

            Console.WriteLine("You have choosed to create Account");
            Console.WriteLine("\n");


            Console.WriteLine("Enter Account Details");
            bank.AddAccount(new Account("New Nayeem", 2000, new Address("20", "10", "Dhaka", "Bangladesh")));

            Console.WriteLine("Account Created successfully");


            Console.WriteLine("Deposit Money Option Choosen");

            bank.Transaction(3);

            
            bank.Transaction(2);

            Console.WriteLine("Transfer Balance Option Choosen");
            bank.Transaction(4);

            Console.WriteLine("Delete Account Option Choosen");

            bank.Deleteccount(2002);


            Console.WriteLine("All of the Accounts of the Bank");
            bank.PrintAllAccount();


        }
    }
}
