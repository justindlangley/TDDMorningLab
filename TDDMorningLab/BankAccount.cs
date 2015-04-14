using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDMorningLab
{
    public class BankAccount
    {
        public int accountNumber { get; set; }
        public string accountName { get; set; }
        public double accountBalance {get; set;}

        BankAccount myCustomer = new BankAccount();

        public virtual string errorMessage()
        {
            this.accountNumber = 131; 
                         
        }
        
        public 
        

        
            
    }
}
