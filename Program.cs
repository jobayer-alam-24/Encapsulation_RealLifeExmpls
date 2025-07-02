using Encapsulation_RealLifeExmpls.models;

namespace Encapsulation_RealLifeExmpls
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount = new BankAccount(5000);
            bankAccount.Deposit(500);
            Console.WriteLine($"Current Balance: {bankAccount.Balance}");
            bankAccount.WidthDraw(100);
            Console.WriteLine($"Current Balance: {bankAccount.Balance}");
            CoffeeMachine myMachine = new CoffeeMachine(1000, 100);
            myMachine.MakeExpresso();
            Console.WriteLine($"Beans Left: {myMachine.BeansLeft()}");
        }
    }
}