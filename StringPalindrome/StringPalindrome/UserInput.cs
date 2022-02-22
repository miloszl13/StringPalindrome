using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPalindrome
{
    public class UserInput
    {
        public string AskForWord()
        {
            Console.WriteLine("Insert some word:");
            var word = Console.ReadLine().ToLower();
            return word;
        }
    }
}
