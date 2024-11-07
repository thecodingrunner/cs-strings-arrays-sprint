using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_arrays_strings_lists
{
    public class Task2
    {
        public static int FindIndex(string inputToFind, string stringToSearch)
        {
            //char charToFind = inputToFind.ToCharArray()[0];
            return stringToSearch.IndexOf(inputToFind);
        }
        public static bool IsFriendHere(List<string> friends, string friendToFind)
        {
            foreach (string friend in friends)
            {
                if (friend == friendToFind) return true;
            }
            return false;
        }
    }
}
