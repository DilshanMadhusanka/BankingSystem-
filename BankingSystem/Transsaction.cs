using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class Transsaction
    {
        public decimal Amount { get; }
        public DateTime Date { get; }

        public String Note { get; }



        // to set the values  we create the constructor  

        Transsaction(decimal amount, DateTime date, String note)
        {
            this.Amount = amount;
            this.Date = date;
            this.Note = note;

        }

    }
}
