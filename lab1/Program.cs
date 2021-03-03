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
            Bank bank = new Bank("Coders Bank", 6);
            for (int i = 0; i < 6; i++)
            {
                bank.AddAccount(new Account("nayeem", 2000, new Address("20", "10", "Dhaka", "Bangladesh")));
                bank.AddAccount(new Account("Johnny", 3000, new Address("40", "30", "Chittagong", "Bangladesh")));
                bank.AddAccount(new Account("John", 4000, new Address("40", "30", "Sylhet", "Bangladesh")));
                bank.AddAccount(new Account("Rik", 2000, new Address("20", "10", "Dhaka", "Bangladesh")));

            }
            Console.WriteLine("Welcome to the " + bank.BankName);

            Console.WriteLine("Choose your option");
            Console.WriteLine("1. Create an Account");
            Console.WriteLine("2. Withdraw Balance");
            Console.WriteLine("3. Deposit Balance");
            Console.WriteLine("4. Transfer Balance");
            Console.WriteLine("5. Delete Account");
            Console.WriteLine("6. Show Account Details ");

            Console.WriteLine("Account Created");
           


            Console.WriteLine("Enter Account Details");
            
            Console.WriteLine("Account Created successfully");


            Console.WriteLine("Deposit Money Option Choosen");

            bank.Transaction(3);

            
            bank.Transaction(2);

            Console.WriteLine("Transfer Balance Option Choosen");
            bank.Transaction(4,1002);

            Console.WriteLine("Delete Account Option Choosen");

            bank.Deleteccount(1004);


            Console.WriteLine("All of the Accounts of the Bank");
            bank.PrintAllAccount();
            


        }
    }
}
