using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;


namespace TDDMorningLabTests
{
    public class BankAccountTests
    {
        [Fact]

        private BankAccountTests checkAccountNumber = new BankAccountTests();


        public void DoesAccountNumberHaveValue()
        {

            int answer = checkAccountNumber.DoesAccountNumberHaveValue();

            Assert.Equal(answer, accountNumber);

                //Happy path is that there is a value, and the test passes
                //Sad path is that there is no value, or the value is not in the correct format,
                //and therefore the test fails
            
        }
    }
    
    
     
    
}
