using System.Security.Principal;

namespace BankingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {

      
            BankAccount bankAccount = new BankAccount();

            //bankAccount.BankDetails(10000, "Brenden", 67890, "Cape Bank", "Savings", "CB123456");

            bankAccount.GetMoney();
            bankAccount.Getname();
            bankAccount.GetId();
            bankAccount.Getbank();
            bankAccount.GetType();
            bankAccount.GetNum();

       

            
        }
    }
}
