using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_arrays_strings_lists
{
    public class Task4
    {
        public static string ReturnWordsBetweenParentheses(string input)
        {
            string[] output = input.Split('(',')');
            
            return output[1]; //change code here
        }
    }
}
