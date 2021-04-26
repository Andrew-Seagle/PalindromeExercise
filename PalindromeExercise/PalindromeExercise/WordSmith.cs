using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string str)
        {
            return str != null && str.SequenceEqual(str.Reverse());
        }
    }
}
