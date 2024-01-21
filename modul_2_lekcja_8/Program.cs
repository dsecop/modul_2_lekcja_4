using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace modul_2_lekcja_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            int numberofprimenumbers = CountPrimeNumber();
            Console.WriteLine(numberofprimenumbers);

            // Task 2
            int i = 0;
            do
            {
                if (i == 0)
                {
                    i++;
                    continue;
                }
                else if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            while (i <= 1000);

            // Task 3
            int nextNumber = 0;
            int prevNumber = 1;
            int nthNumber;
            for (var n = 0; n < 10; n++)
            {
                if (n == 0)
                {
                    Console.WriteLine(n);
                }
                else if (n == 1)
                {
                    Console.WriteLine(n);
                }
                else
                {
                    nthNumber = nextNumber + prevNumber;
                    nextNumber = prevNumber;
                    prevNumber = nthNumber;
                    Console.WriteLine(nthNumber);
                }
            }

            // Task 4
            int number = 10;
            int counter = 1;
            for (int row = 1; row <= number; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    if (number < counter)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write($" {counter}");
                        counter++;
                    }
                }
                Console.WriteLine();
            }

            // Task 5
            int number = 10;
            int power = 3;
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"Number {i} raised to the third power is: {Math.Pow(i, power)}");
            }

            // Task 6
            double result = 0;
            double numerator = 1;
            for (int i = 1; i <= 20; i++)
            {
                result += numerator / i;
            }
            Console.WriteLine($"Result: {result:N3}");

            // Task 7
            string pattern = DrawDiamond();
            Console.WriteLine(pattern);

            // Task 8
            string newString = ReverseText("Abcdefg");
            Console.WriteLine(newString);

            // Task 9
            string binaryNumber = ConvertDecimalToBinary();
            Console.WriteLine(binaryNumber);

            // task 10
            int lcm = LeastCommonMultiple();
            Console.WriteLine($"The least common multiple of the given numbers is: {lcm}");
        }
        static int LeastCommonMultiple()
        {
            Console.Write("Enter the first number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int b = int.Parse(Console.ReadLine());

            int lcm = a * b;

            while (b > 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            lcm /= a;
            return lcm;
        }

        static string ConvertDecimalToBinary()
        {
            Console.Write("Enter a decimal number: ");
            int n = int.Parse(Console.ReadLine());
            string binaryNumber = "";
            while (n > 0)
            {
                binaryNumber = (n % 2) + binaryNumber;
                n /= 2;
            }
            return binaryNumber;
        }

        static string ReverseText(string userInput)
        {
            char[] charArray = userInput.ToCharArray();
            Array.Reverse(charArray);
            string reversed = new(charArray);
            reversed = reversed.ToLower();
            return $"{reversed[0].ToString().ToUpper()}{reversed.Substring(1)}";
        }
        static string DrawDiamond()
        {
            Console.Write("Enter the diagonal length: ");
            int diagonal = int.Parse(Console.ReadLine());

            for (int x = 1; x < diagonal; x++)
            {
                for (int y = x; y <= diagonal; y++)
                {
                    Console.Write(" ");
                }
                for (int z = 1; z <= x; z++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            for (int x = 1; x <= diagonal; x++)
            {
                for (int y = 1; y <= x; y++)
                {
                    Console.Write(" ");
                }
                for (int z = x; z <= diagonal; z++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
            return "";
        }

        static bool IsPrimeNumber(int n)
        {
            if (n == 1)
            {
                return false;
            }
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static int CountPrimeNumber()
        {
            List<int> myList = [];
            for (int j = 1; j <= 100; j++)
            {
                if (IsPrimeNumber(j))
                {
                    myList.Add(j);
                }
            }
            return myList.Count();
        }
    }
}
