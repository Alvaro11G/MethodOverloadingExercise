using System;

namespace MethodOverloadingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;

            int intAnswer = Add(a, b);

            decimal x = 5.5m;
            decimal y = 2.5m;

            decimal deciAnswer = Add(x, y);

            String stringAnswer = Add(1, 5, true);

            Console.WriteLine("int Add method: " + intAnswer + " Decimal Add method: " + deciAnswer);
            Console.WriteLine(stringAnswer);
        }

        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        static String Add(int num1, int num2, bool Check)
        {
            int sum = num1 + num2;

            if (Check == true && sum == 1)
            {
                return $"{sum} Dollar";
            }
            else if (Check == true && sum > 1)
            {
                return $"{sum} Dollars";
            }
            else
            {
                return sum.ToString();
            }
        }
    }
}
