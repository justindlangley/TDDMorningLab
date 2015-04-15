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
<<<<<<< HEAD

            string AllConsonants = "BCDFGHJKLMNPQRSTVWXYZbcdfghjklmnpqrstvwxyz";
            string input = "Short Phrase";
            var query = from ch in input
                        where AllConsonants.IndexOf(ch) != -1
                        select ch;
            return query;
=======
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
>>>>>>> fef6d323b40122a5e839698921f64a7471daee4b
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
