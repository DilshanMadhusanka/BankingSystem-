﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
 public class BankAccount
    {
        /*
         
        The features that should include
         
        it has 10 digit numbers that uniquely identifies the bank account
        it has a string that stores the name or names of the owner
        the balanced can be retrieved
        it accepts deposits
        it accepts withdrawls
         => the initial balance must be positive
         => withdrawal can't result in a negative balance
        
         */

        /* definet the properties and get set method */

        public String Number { get;  }
        public String Owner { get; set; }
        public decimal Balance { get;  }

        // auto generate banknumber   

        private static int accountNumberSeed = 1234567890; // static keyword eka nisa account number eka mula idan aluth account hadankot run wen na . kalin hadal stop un thanin issarahat yanwa

        // methana get krala witharak thiyan properties walata class eka athukenma set property eka set krann oni. ekata constructor eka hadanwa


        // Constructor  

        public BankAccount( String name , decimal initialBalance)
        {
            this.Owner = name;
            this.Balance = initialBalance ;

            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }



        public void MakeDeposite (decimal amount , DateTime date , String note)
        { }

        public void MakeWithdrawal (decimal amount , DateTime date , String note) 
        { }

    }
}
