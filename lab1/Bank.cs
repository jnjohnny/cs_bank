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
                    break;
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
            Account a2 = new Account();
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
                a2.deposit(x);

            }

            if (s == 4)
            {
                Console.WriteLine("Enter The Account Number Where you want to Transfer");
                myBank[3].transfer(myBank[1], 50);
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
                myBank[i].print();
            }
        }

        public void SearchAccount(int accountNumber)
        {
            //int flag = 0;
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    continue;
                }
                else if (myBank[i].AccountNumber == accountNumber)
                {
                    myBank[i].ShowAccountInformation();
                    flag = 0;
                    break;
                }
                else
                {
                    flag = 1;
                }

            }
            if (flag == 1)
                Console.WriteLine("Account not found");
        }
    }
}
