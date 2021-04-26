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
            if (str == null)
                return false;
            var strRev = str.ToCharArray();
            Array.Reverse(strRev);
            return str.ToCharArray().SequenceEqual(strRev);
        }
    }
}
