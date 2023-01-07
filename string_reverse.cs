using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User, this program takes a piece of text as input and return it in reverse order.");
            Console.WriteLine("Please enter your text: ");
            string originalString = Console.ReadLine().ToLower();
            string reversedString = String.Empty;

            for (int i = 0; i <= originalString.Length - 1; i++)
            {
                reversedString = originalString[i] + reversedString;
            }

            if (reversedString == originalString)
            {
                Console.WriteLine("The text is a palindrome, you solved your own problem");
            }
            else
            {
                Console.WriteLine($"This is the entered text in reverse order: {reversedString}.");
            }
        }
    }
}