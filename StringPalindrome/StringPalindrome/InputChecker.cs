using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPalindrome
{
    public class InputChecker
    {
        IChecking _checking;
        public InputChecker(IChecking checking)
        {
            _checking = checking;
        }
        public bool Check(string word)
        {
            return _checking.Check(word);
        }
    }
}
