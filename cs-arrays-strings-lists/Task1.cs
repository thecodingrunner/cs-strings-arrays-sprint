using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_arrays_strings_lists
{
    public class Task1
    {
        public static int[]? ArraySort(int[] arrayToSort)
        {
            //int[] answer = { 1, 2, 9, 24, 30, 40 };
            Array.Sort(arrayToSort); //change code here
            return arrayToSort;
            //return answer;
        }
        public static string ShoutString(string stringToShout)
        {
            //string answer = "HELLO EVERYONE HERE AT NORTHCODERS";
            return stringToShout.ToUpper(); //change code here
            //return answer;
        }
    }
}

