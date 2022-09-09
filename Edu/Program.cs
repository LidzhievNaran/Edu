using System;

namespace Edu
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=> Data type Parsing:");
            bool b = bool.Parse("True");
            Console.WriteLine("Value of b: {0}", b);
            double d = double.Parse("2312");// не хочет работать с десятичными
            Console.WriteLine("Value of d: {0}", d);
            int c = int.Parse("1000");
            Console.WriteLine("Value of c: {0}", c);
            
        }
    }
}