using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Account
    {
        private int accountNumber;
        private string accountName;
        private double balance;
        private Address address;
        int a = 1;

        public int AccountNumber
        {
            //set { this.accountName = value; }
            get { return accountNumber; }
        }

        public string AccountName
        {
            set { this.accountName = value; }
            get { return this.accountName; }
        }
        public double Balance
        {
            set { this.balance = value; }
            get { return this.balance; }
        }

        public Address Address
        {
            set { this.address = value; }
            get { return this.address; }
        }

        public void PrintAccount()
        {

            Console.WriteLine("\nAccount Name:{0}\nBalance:{1}", this.accountName, this.balance);
            this.address.GetAddress();
        }



        public void print()
        {
            this.accountNumber = a;
            Console.WriteLine("Your Account No is=" + this.accountNumber + "\n");
            a++;
        }



        public void deposit(double amount)
        {
            if (amount > 0)
            {
                Console.WriteLine("Previous Balance: " + balance);
                Console.WriteLine("Deposit Amount: " + amount);
                balance += amount;
                Console.WriteLine("Current Balance: " + balance);
            }
            else
            {
                Console.WriteLine("Can Not Deposit");
            }
        }



        public void withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                Console.WriteLine("Previous Balance:	" + balance);
                Console.WriteLine("Withdraw Amount:	" + amount);
                balance -= amount;
                //balance = balance - amount;
                Console.WriteLine("Current Balance:	" + balance);
            }
            else
            {
                Console.WriteLine("Can Not Withdraw");
            }
        }





        public void transfer(Account a, double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                Console.WriteLine("Previous Balance:	" + this.balance);
                Console.WriteLine("Transfer Amount:	" + amount);
                this.balance = this.balance - amount;
                // a.balance = a.balance + amount;
                Console.WriteLine("Current Balance:	" + this.balance);
            }
            else
            {
                Console.WriteLine("Can Not Transfer");
            }
        }

    }
}
