using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Account
    {
        private int accountNumber;
        private string accountName;
        private double balance;
        private Address address;
        static int z = 1001;


        public Account()
        { }

        public Account(string accountName, double balance, Address address)
        {
            //this.accountNumber;
            this.accountName = accountName;
            this.balance = balance;
            this.address = address;
        }
        public int AccountNumber
        {
            //set { this.accountNumber = value; }
            get { return this.accountNumber; }
        }

        public void print()
        {
            accountNumber = z;
            Console.WriteLine("Your Account No is=" + accountNumber + "\n");
            z++;
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




        public void transfer(Account receiver, double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                Console.WriteLine("Previous Balance:	" + this.balance);
                Console.WriteLine("Transfer Amount:	" + amount);
                this.balance = this.balance - amount;
                Console.WriteLine("Current Balance:	" + this.balance);
            }
            else
            {
                Console.WriteLine("Can Not Transfer");
            }
        }

        public void ShowAccountInformation()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Account Name:{0}\nBalance:{1}", this.accountName, this.balance);
                this.address.GetAddress();
                break;
            }

         }
    }
}
