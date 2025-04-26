using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://leetcode.com/problems/palindrome-number/description/

namespace Leetcode.Challenges.Easy
{
    public class PalindromeNumber
    {
        public static bool IsPalindrome(int x)
        {
            char[] asCharArr = Math.Abs(x).ToString().ToCharArray();

            if (asCharArr[0] == asCharArr[asCharArr.Length-1])
            {
                return true;
            }

            return false;

        }
    }
}
