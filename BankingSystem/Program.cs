using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingSystem;  // after creating classes this command should be added

namespace BankingSystem
{
  public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount( "DILSHAN " , 5000);  // new key word eka dala object ekak hadankot automaticaly constructor is called.
            BankAccount account2 = new BankAccount("kamal", 35000);
           // BankAccount account3 = new BankAccount("Ahinsa", 33434);

            // Console.WriteLine(account1.Owner );
            // Console.WriteLine(account1.Balance);
            // Console.ReadLine(); 

            Console.WriteLine($"This account is for {account1.Owner} and the number is {account1.Number}");
            Console.WriteLine($"This account is for {account2.Owner} and the number is {account2.Number}");
           // Console.WriteLine($" this account is for {account3.Owner} and the number is {account3.Number}");


            Console.ReadLine();



           

        }
    }
}
