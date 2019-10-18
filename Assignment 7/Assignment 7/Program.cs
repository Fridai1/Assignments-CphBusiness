using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("you current balance: " + bank.Balance);
                Console.WriteLine("deposit or withdraw?");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "deposit":
                    {
                        Console.WriteLine("amount?");
                        string amount = Console.ReadLine();
                        double dAmount = double.Parse(amount);
                        Console.WriteLine(bank.Deposit(dAmount));
                        break;
                    }
                    case "withdraw":
                    {
                        Console.WriteLine("amount?");
                        string amount = Console.ReadLine();
                        double dAmount = double.Parse(amount);
                        Console.WriteLine(bank.Withdraw(dAmount));
                        break;
                    }
                }

                
            }
        }
    }
}
