using PalindromeNumber.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number");
            int number = int.Parse(Console.ReadLine());
            if (CheckPalindrome.ToCheckPalindrome(number))
            {
                Console.WriteLine($"The Number {number} is Palindrome");
            }
            else
            {
                Console.WriteLine($"The Number {number} is NOt a Palindome");
            }
            
        }
    }
}
