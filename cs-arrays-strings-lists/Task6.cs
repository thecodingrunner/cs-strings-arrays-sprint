using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_arrays_strings_lists
{
    public class Task6
    {
        public static string SwapLastInstanceCase(string[] words, string searchString)
        {

            List<int> indexList = [];
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].ToLower() == searchString.ToLower())
                {
                    indexList.Add(i);
                }
            }
            string modifiedWord = "";

            foreach (char c in words[indexList[indexList.Count -1]])
            {
                if (Char.IsUpper(c))
                {
                    modifiedWord += Char.ToLower(c);
                }
                if (Char.IsLower(c))
                {
                    modifiedWord += Char.ToUpper(c);
                }
            }
            words[indexList[indexList.Count -1]] = modifiedWord;
            string output = String.Join(" ", words);

            return output; //change code here
        }
    }
}

