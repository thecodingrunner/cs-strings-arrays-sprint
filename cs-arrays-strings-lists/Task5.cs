using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_arrays_strings_lists
{
    public class Task5
    {
        public static List<string> RemoveWordStartingWithVowel(List<string> words)
        {
            List<string> filteredWords = words.Where(word => "aeiouAEIOU".IndexOf(word[0]) < 0).ToList();
            return filteredWords; //change code here
        }
    }
}
