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






        public IEnumerable<char> GetConsonants()
        {

            string AllConsonants = "BCDFGHJKLMNPQRSTVWXYZbcdfghjklmnpqrstvwxyz";
            string input = "Short Phrase";
            var query = from ch in input
                        where AllConsonants.IndexOf(ch) != -1
                        select ch;
            return query;
        }





        //var output = new List<char>
        //{
        //    'S', 'h', 'r', 't',
        //    'p', 'h','r','s'
        //};



        public object AlphaOrder()
        {
            string AllConsonants = "BCDFGHJKLMNPQRSTVWXYZbcdfghjklmnpqrstvwxyz";
            var query = from ch in input
                        where AllConsonants.IndexOf(ch) != -1
                        orderby char.ToLower(ch)
                        select ch;
            return query;
        }

    }

}
