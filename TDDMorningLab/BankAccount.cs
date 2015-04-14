using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDMorningLab
{
    public class BankAccount
    {
        public int accountNumber
        {
            get
            {
                return accountNumber == null ? Console.WriteLine("A value must exist here");
            }

            set; }
        public string accountName { get; set; }
        public double accountBalance {get; set;}

        BankAccount customer1 = new BankAccount();
            
    }
}
