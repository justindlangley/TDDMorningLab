using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDMorningLab;
using Xunit;


namespace TDDMorningLabTests
{
    public class StringIEnumTests
    {

        [Fact]
        public void CanFindConsantants()
        {
            var input = "Short phrase";

            var engine = new ThingJonathanWillBuild(input);

            var answer = engine.GetConsonants();

            var output = new List<char>
            {
                'S', 'h', 'r', 't',
                'p', 'h','r','s'
            };
            

            Assert.Equal(output, answer);
        }

                //Happy path is that there is a value, and the test passes
                //Sad path is that there is no value, or the value is not in the correct format,
                //and therefore the test fails

            [Fact]
            public void AreConsonantsInAlphabeticalOrder()
            {
                var input = "Short phrase";

                var engine = new ThingJonathanWillBuild(input);
                var answer = engine.AlphaOrder();
                var output = new List<char>
                {
                    'h', 'h', 'p', 'r', 
                    'r', 's', 's', 't'
                };

                Assert.Equal(output, answer);
            }
            [Fact]
            public void AreConsonantsOnlyReturnedOnce()
            {
                var input = "Short phrase";

                var engine = new ThingJonathanWillBuild(input);
                var answer = engine.UsedOnce();
                var output = new List<char>
                {
                    'h', 'p', 'r', 's', 't'
                };

                Assert.Equal(output, answer);

            }  
    }
 }
    
    
     
    

