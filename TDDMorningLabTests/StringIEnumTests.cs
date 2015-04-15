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
            var input = "Short";

            var engine = new ThingJonathanWillBuild(input);

            var answer = engine.GetConsonants();

            var output = new List<char>
            {
<<<<<<< HEAD
                'S', 'h', 'r', 't',
                'P', 'h','r','s'
=======
                'S', 'h', 'r', 't'
>>>>>>> fef6d323b40122a5e839698921f64a7471daee4b
            };

        }

        [Fact]
        public void AlphabeticalOrder()
        {
            var input = "Short phrase";

<<<<<<< HEAD
            var engine = new ThingJonathanWillBuild(input);

            var answer = engine.AlphaOrder();

            var output = new List<char>
=======
            [Fact]
            public void AreConsonantsInAlphabeticalOrder()
            {
                var input = "Short";

                var engine = new ThingJonathanWillBuild(input);
                var answer = engine.AlphaOrder();
                var output = new List<char>
                {
                    'h', 'r', 'S', 't'
                };

                Assert.Equal(output, answer);
            }
            [Fact]
            public void AreConsonantsOnlyReturnedOnce()
>>>>>>> fef6d323b40122a5e839698921f64a7471daee4b
            {
                'h', 'r', 'S', 't',
                'h', 'P', 'r', 's'
            };

<<<<<<< HEAD
        }
        //[Fact]
=======
                var engine = new ThingJonathanWillBuild(input);
                var answer = engine.UsedOnce();
                var output = new List<char>
                {
                    'S','h', 'p', 'r', 's', 't'
                };
>>>>>>> fef6d323b40122a5e839698921f64a7471daee4b

        //public void CanFindConsantants()
        //{
        //    var input = "Short phrase";

        //    var engine = new ThingJonathanWillBuild(input);

        //    var answer = engine.GetConsonants();

        //    var output = new List<char>
        //    {
        //        'S', 'h', 'r', 't',
        //        'P', 'h','r','s'
        //    };

        //}
        //[Fact]
        //public void CanFindConsantants()
        //{
        //    var input = "Short phrase";

        //    var engine = new ThingJonathanWillBuild(input);

        //    var answer = engine.GetConsonants();

        //    var output = new List<char>
        //    {
        //        'S', 'h', 'r', 't',
        //        'P', 'h','r','s'
        //    };

        //    Assert.Equal(output, answer);

            //Happy path is that there is a value, and the test passes
            //Sad path is that there is no value, or the value is not in the correct format,
            //and therefore the test fails

        }
    }
