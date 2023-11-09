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
            
            // Console.WriteLine(account1.Owner );
            // Console.WriteLine(account1.Balance);
            // Console.ReadLine(); 
          
        }
    }
}
