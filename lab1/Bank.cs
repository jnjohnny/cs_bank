using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Bank
    {
        private string bankName;
        private Account[] myBank;

        public Bank(string bankName, int size)
        {
            this.bankName = bankName;
            this.myBank = new Account[size];
        }

        public string BankName
        {
            set { this.bankName = value; }
            get { return this.bankName; }
        }

        public Account[] MyBank
        {
            get { return this.myBank; }
        }

        public void AddAccount(Account account)
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    myBank[i] = account;
                    
                }
            }
        }

        public void Deleteccount(int accountNumber)
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    continue;
                }
                else if (myBank[i].AccountNumber == accountNumber)
                {
                    myBank[i] = null;
                    Console.WriteLine("Account Deleted\n");
                    for (int j = i; j < myBank.Length - 1; j++)
                    { myBank[j] = myBank[j + 1]; }
                }
            }
        }

        public void Transaction(int s, params int[] ab)
        {
            
            if (s == 2)
            {
                Console.WriteLine("Enter The Amount You want to Withdraw: ");
                double x = Convert.ToDouble(Console.ReadLine());
                myBank[3].withdraw(x);
            }


            if (s == 3)
            {
                Console.WriteLine("Enter The Amount You want to Deposit: ");
                double x = Convert.ToDouble(Console.ReadLine());
                myBank[2].deposit(x);

            }

            if (s == 4)
            {
                Console.WriteLine("Enter The Account Number Where you want to Transfer");
                myBank[2].transfer(myBank[1], 120);
            }

        }

        public void PrintAllAccount()
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    continue;
                }
                myBank[i].ShowAccountInformation();
                myBank[i].autoId();
                
            }
        }

        
    }
}
