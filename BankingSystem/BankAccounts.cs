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
     class BankAccount
    {
        private int money;
        private string name;
        private long id;
        private string bankName;
        private string bankType;
        private string accountNum;

        public string PrintDetails()
        {
            this.money = money;
            this.name = name;
            this.id = id;
            this.bankName = bankName;
            this.bankType = bankType;
            this.accountNum = accountNum;

            return $"Account Holder: {name}, ID: {id}, Bank Name: {bankName}, Bank Type: {bankType}, Account Number: {accountNum}, Balance: {money}";
    
        }


        public void GetMoney()
        {
            Console.WriteLine("Enter the ammount you want to pull: ");
            this.money = int.Parse(Console.ReadLine());
        }

        public void Getname()
        { 
            Console.WriteLine("Enter your name?: ");
            this.name = Console.ReadLine();
        }

        public void GetId()
        {
            Console.WriteLine("Identification Please?: ");
            try
            {
                this.id= long.Parse(Console.ReadLine());
            }
            catch(OverflowException)
            {
                Console.WriteLine("The Id you entered is too large. Please try again.");
            }
            catch(FormatException)
            {
                Console.WriteLine("The Id you entered is not a number. Please try again.");
            }
            
        }

        public void Getbank()
        {
            Console.WriteLine("What's your bank name?: ");
            this.bankName = Console.ReadLine();
        }

        public void GetType()
        {
            Console.WriteLine("What type is your bank?: ");
            this.bankType = Console.ReadLine();
        }

        public void GetNum()
        {
            Console.WriteLine("What is your account number?: ");
            this.accountNum = Console.ReadLine();
        }

    }
        
}

