using System.Security.Principal;

namespace BankingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

      
            BankAccount bankAccount = new BankAccount();



            BankAccount.GetMoney();
            BankAccount.Getname();
            BankAccount.GetId();
            BankAccount.Getbank();
            BankAccount.GetType();
            BankAccount.GetNum();

      
            Console.WriteLine(BankAccount.PrintDetails());



        }
    }
}
