using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDMorningLab
{




    public class ThingJonathanWillBuild
    {
        public string input;

        public ThingJonathanWillBuild(string input)
        {
            // TODO: Complete member initialization
            this.input = input;
        }






        public IEnumerable<char> GetConsonants()
        {
            string AllConsonants = "BCDFGHJKLMNPQRSTVWXYZbcdfghjklmnpqrstvwxyz";
            
            var query = from ch in input
                   where AllConsonants.IndexOf(ch) != -1
                   select ch;
                   return query;
            
        }

        public IEnumerable<char> AlphaOrder()
        {
           string AllConsonants = "BCDFGHJKLMNPQRSTVWXYZbcdfghjklmnpqrstvwxyz";
            var query = from ch in input 
                        where AllConsonants.IndexOf(ch) != -1
                        orderby char.ToLower(ch)
                        select ch;
                        return query; 
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
