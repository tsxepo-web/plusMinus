using System;
using System.Linq;
namespace plusMinus
{
    class Program
    {
        decimal[] numbers = { -4m, 3m, -9m, 0m, 4m, 1m };


        public decimal GetHowManyNegativeNumbersInArray()
        {
            decimal n = numbers.Length;
            var negativeNumbers = new List<decimal> { };

            foreach (decimal number in numbers)
            {
                if (number < 0)
                {
                    negativeNumbers.Add(number);
                }
            }
            return negativeNumbers.Count / n;
        }

        public decimal GetHowManyPositiveNumbersInArray()
        {
            decimal n = numbers.Length;
            var positiveNumbers = new List<decimal> { };

            foreach (decimal number in numbers)
            {
                if (number > 0)
                {
                    positiveNumbers.Add(number);
                }
            }
            return positiveNumbers.Count / n;
        }

        public decimal GetHowManyZerosInArray()
        {
            decimal n = numbers.Length;
            var positiveNumbers = new List<decimal> { };

            foreach (decimal number in numbers)
            {
                if (number == 0)
                {
                    positiveNumbers.Add(number);
                }
            }
            return positiveNumbers.Count / n;
        }
        static void Main(string[] args) 
        {
            Program numbers= new Program();
            Console.WriteLine(numbers.GetHowManyPositiveNumbersInArray());

            Console.WriteLine(numbers.GetHowManyNegativeNumbersInArray());
            Console.WriteLine(numbers.GetHowManyZerosInArray());
            Console.ReadLine();
        }
    }
}