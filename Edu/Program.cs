using System;

namespace Edu
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            char myChar = 'f';
            Console.WriteLine("char.isDigit ('a'): {0}", char.IsDigit(myChar));
            Console.WriteLine("char.isLetter ('a'): {0}", char.IsLetter(myChar));
            Console.WriteLine("char.IsWhiteSpace('Hello There’, 5): {0}",
                char.IsWhiteSpace("Hello There", 5));
            Console.WriteLine("char.IsWhiteSpace('Hello There', 6): {0}",
                char.IsWhiteSpace("Hello There", 6));
            Console.WriteLine("char.IsPunctuation(’?'): {0}",
                char.IsPunctuation('?'));
            Console.WriteLine();
        }
    }
}