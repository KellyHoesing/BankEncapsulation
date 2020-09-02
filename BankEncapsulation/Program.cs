using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var myAccount = new BankAccount();
            Console.WriteLine("How much would you like to deposit?");
            myAccount.Deposit(int.Parse(Console.ReadLine()));
            myAccount.GetBalance();
        }
    }
}
