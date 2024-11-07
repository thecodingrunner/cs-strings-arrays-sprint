using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_arrays_strings_lists
{
    public class Task3
    {
        public static string SlowDownSentence(string stringToSlow)
        {
            string[] array = stringToSlow.Split();
            return String.Join("... ", array) + "... ";
        }
    }
}
