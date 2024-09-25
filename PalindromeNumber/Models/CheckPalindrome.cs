using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber.Models
{
    internal class CheckPalindrome
    {
        public static bool ToCheckPalindrome(int number)
        {
            int tempValue = number;
            int Reverse = 0;
            while (tempValue > 0)
            {
                int lastNumber = tempValue % 10;
                Reverse = (Reverse * 10) + lastNumber;
                tempValue = tempValue / 10;
            }
            return Reverse == number;
        }

    }
}
