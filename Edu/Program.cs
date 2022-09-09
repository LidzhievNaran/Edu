using System;

namespace Edu
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            char myChar = 'a';
            Console.WriteLine("char.isDigit ('a'): {0}", char.IsDigit(myChar));
            Console.WriteLine("char.isLetter ('a'): {0}", char.IsLetter(myChar));
            
        }
    }
}