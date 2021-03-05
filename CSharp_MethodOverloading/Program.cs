using System;

namespace CSharp_MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine($"{Add(1,4,true)}");
            Console.WriteLine($"{Add(1, 0, true)}");
            Console.WriteLine($"{Add(12, 4, true)}");

            Console.WriteLine($"No grammar suffix");
            Console.WriteLine($"{Add(1, 4, false)}");
            Console.WriteLine($"{Add(1, 0, false)}");
            Console.WriteLine($"{Add(12, 4, false)}");



        }

        public static int Add(int number1, int number2)
        {
            return number1 + number2;
        }
        public static decimal Add(decimal number1, decimal number2)
        {
            return number1 + number2;
        }

        public static string Add(int number1, int number2, bool addGrammar)
        {
            int sum = Add(number1, number2);

            return addGrammar ? (sum == 1 ? $"{sum} dollar" : $"{sum} dollars") : $"{sum}";
        }
    }
}
