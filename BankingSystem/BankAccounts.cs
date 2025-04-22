using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
     class BankAccount()
    {
        int Money;
        string name;
        int Id;
        string bankName;
        string bankType;
        string AccountNum;

        public void BankDetails(int money, string name, int Id, string bankName, string bankType, string AccountNum)
        {
            Money = money;
            this.name = name;
            this.Id = Id;
            this.bankName = bankName;
            this.bankType = bankType;
            this.AccountNum = AccountNum;

        }

        public void GetMoney()
        {
            Console.WriteLine("Enter the ammount you want to pull: ");
            int Money = int.Parse(Console.ReadLine());
            
            
        }

        public void Getname()
        { 
            Console.WriteLine("Enter your name?: ");
            string name = Console.ReadLine();
            

        }

        public void GetId()
        {
            Console.WriteLine("Identification Please?: ");
            int id = int.Parse(Console.ReadLine());
            
        }

        public void Getbank()
        {
            string bankName = Console.ReadLine();
            Console.WriteLine("What's your bank name?: ");
            
        }

        public void GetType()
        {
            string type = Console.ReadLine();
            Console.WriteLine("What type is your bank?: ");
        }

        public void GetNum()
        {
            Console.WriteLine("What is your account number?: ");
            int accountNum = int.Parse(Console.ReadLine());
        }

    }
        
}

