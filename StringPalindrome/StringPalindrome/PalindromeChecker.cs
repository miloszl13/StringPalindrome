using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPalindrome
{
    public class PalindromeChecker:IChecking
    {
        public bool Check(string word)
        {
            for (int i = 0, j = word.Length - 1; i < word.Length; i++, j--)
            {
                if (word[i] != word[j])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
