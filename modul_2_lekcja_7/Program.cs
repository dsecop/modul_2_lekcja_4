namespace modul_2_lekcja_7
{
    enum Weekday
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7,
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            int a = 5;
            int b = 5;

            if (a == b)
            {
                Console.WriteLine("Variable [a] is equal to variable [b]");
            }
            else
            {
                Console.WriteLine("Variable [a] is NOT equal to variable [b]");
            }

            // Task 2
            int c = 15;
            if (c % 2 == 0)
            {
                Console.WriteLine("Variable [c] is even");
            }
            else
            {
                Console.WriteLine("Variable [c] is odd");
            }

            // Task 3
            int d = 14;
            if (d >= 0)
            {
                Console.WriteLine("Variable [d] is a positive number");
            }
            else
            {
                Console.WriteLine("Variable [d] is a negative number");
            }

            // Task 4
            int year = 2016;
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            {
                Console.WriteLine($"{year} is a leap year");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year");
            }

            // Task 5
            Console.Write("Please, type how old are you?: ");
            int age = int.Parse(Console.ReadLine());

            if (age >= 21)
            {
                Console.WriteLine("You can become an member of parliament or even prime minister");
                if (age >= 30)
                {
                    Console.WriteLine("You can become a senator");
                    if (age >= 35)
                    {
                        Console.WriteLine("You can become president");
                    }
                }
            }
            else
            {
                Console.WriteLine("You cannot run for office");
            }

            // Task 6
            Console.Write("Enter your height: ");
            int height = int.Parse(Console.ReadLine());

            if (height >= 140 && height < 170)
            {
                Console.WriteLine("You are a dwarf");
            }
            else if (height >= 170 && height < 200)
            {
                Console.WriteLine("You are an elf");
            }
            else if (height >= 200)
            {
                Console.WriteLine("You are a giant");
            }
            else
            {
                Console.WriteLine("You are a Lilliputian");
            }

            // Task 7
            List<int> numbers = [];

            Console.WriteLine("Type 3 numbers separated by a comma: ");
            string userinput = Console.ReadLine();
            string[] words = userinput.Split(',');

            foreach (var word in words)
            {
                numbers.Add(int.Parse(word));
            }
            numbers.Sort();
            Console.WriteLine();
            Console.WriteLine($"{numbers.Last()} is the largest number entered by the user.");

            // or we can use Max() method
            // Console.WriteLine(numbers.Max());

            // Task 8
            Console.Write("Enter your math exam scores: ");
            int mathresults = int.Parse(Console.ReadLine());

            Console.Write("Enter your physics exam scores: ");
            int physicsresults = int.Parse(Console.ReadLine());

            Console.Write("Enter your chemistry exam scores: ");
            int chemistryresults = int.Parse(Console.ReadLine());

            if (mathresults > 70 || physicsresults > 55 || chemistryresults > 45 && (mathresults + physicsresults + chemistryresults) > 180)
            {
                Console.WriteLine("Candidate admitted to recruitment");
            }
            else if ((mathresults + physicsresults) > 150)
            {
                Console.WriteLine("Candidate admitted to recruitment");
            }
            else if ((mathresults + chemistryresults) > 150)
            {
                Console.WriteLine("Candidate admitted to recruitment");
            }
            else
            {
                Console.WriteLine("The candidate has not been admitted to recruitment");
            }

            // Task 9
            Console.Write("Please enter the temperature: ");
            int temperature = int.Parse(Console.ReadLine());

            if (temperature < 0)
            {
                Console.WriteLine("Damn cold");
            }
            else if (temperature == 0 && temperature <= 10)
            {
                Console.WriteLine("Cold");
            }
            else if (temperature >= 10 && temperature <= 20)
            {
                Console.WriteLine("coldly");
            }
            else if (temperature >= 20 && temperature <= 30)
            {
                Console.WriteLine("temperature just right");
            }
            else if (temperature >= 30 && temperature <= 40)
            {
                Console.WriteLine("it's starting be poorly because it's hot");
            }
            else if (temperature >= 40)
            {
                Console.WriteLine("come on, I'm moving to Alaska");
            }
            else
            {
                Console.WriteLine("");
            }

            // Task 10
            List<int> sidelengths = [];

            Console.Write("Enter the length of side A: ");
            int side_a = int.Parse(Console.ReadLine());
            sidelengths.Add(side_a);

            Console.Write("Enter the length of side B: ");
            int side_b = int.Parse(Console.ReadLine());
            sidelengths.Add(side_b);

            Console.Write("Enter the length of side C: ");
            int side_c = int.Parse(Console.ReadLine());
            sidelengths.Add(side_c);

            sidelengths.Sort();

            int longestside = (sidelengths.Max());
            int sumofshortersides = sidelengths[0] + sidelengths[1];

            if (sumofshortersides > longestside)
            {
                Console.WriteLine("A triangle can be built");
            }
            else
            {
                Console.WriteLine("You can't build a triangle");
            }

            // Task 11
            Console.Write("Enter the student's grade [1-6]: ");
            int grade = int.Parse(Console.ReadLine());
            switch (grade)
            {
                case 1:
                    Console.WriteLine("Unsatisfactory ");
                    break;
                case 2:
                    Console.WriteLine("Poor ");
                    break;
                case 3:
                    Console.WriteLine("Satisfactory");
                    break;
                case 4:
                    Console.WriteLine("Good");
                    break;
                case 5:
                    Console.WriteLine("Very good");
                    break;
                case 6:
                    Console.WriteLine("Excellent");
                    break;
            }

            // Task 12
            Console.Write("Type the day number [1-7]: ");
            int day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine(Weekday.Monday);
                    break;
                case 2:
                    Console.WriteLine(Weekday.Tuesday);
                    break;
                case 3:
                    Console.WriteLine(Weekday.Wednesday);
                    break;
                case 4:
                    Console.WriteLine(Weekday.Thursday);
                    break;
                case 5:
                    Console.WriteLine(Weekday.Friday);
                    break;
                case 6:
                    Console.WriteLine(Weekday.Saturday);
                    break;
                case 7:
                    Console.WriteLine(Weekday.Sunday);
                    break;
            }

            // Task 13
            Console.WriteLine("Type the first number: ");
            int firstnumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Type the second number: ");
            int secondnumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Type the operation number to be performed:");
            Console.WriteLine(
                """
                1. Addition
                2. Subtraction
                3. Multiplication
                4. Division
                """
                );
            int operation = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    Console.WriteLine($"Your result is {firstnumber + secondnumber}");
                    break;
                case 2:
                    Console.WriteLine($"Your result is {firstnumber - secondnumber}");
                    break;
                case 3:
                    Console.WriteLine($"Your result is {firstnumber * secondnumber}");
                    break;
                case 4:
                    if (firstnumber == 0 || secondnumber == 0)
                    {
                        Console.WriteLine("Cannot divide by zero!!!");
                    }
                    else
                    {
                        Console.WriteLine($"Your result is {firstnumber / secondnumber}");
                    }
                    break;
            }
        }
    }
}
