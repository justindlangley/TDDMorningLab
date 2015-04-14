using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDMorningLab
{




    public class ThingJonathanWillBuild
    {
        private string input;

        public ThingJonathanWillBuild(string input)
        {
            // TODO: Complete member initialization
            this.input = input;
        }






        public object GetConsonants()
        {
            string myString = "Short phrase";
            char[] vowels = { 'a', 'A', 'e', 'E', 'I', 'i', 'O', 'o', 'U', 'u' };
            string input = myString.ToUpper(vowels);
            return input;
        }

        public object AlphaOrder()
        {
            throw new NotImplementedException();
        }

        public object UsedOnce()
        {
            throw new NotImplementedException();
        }

        public object LowerCaseConsonants()
        {
            throw new NotImplementedException();
        }
    }

}
