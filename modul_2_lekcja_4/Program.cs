namespace modul_2_lekcja_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            Employee employee = new()
            {
                firstname = "John",
                lastname = "Smith",
                age = 23,
                peselnumber = "73052622038",
                employeenumber = 2509324094,
                sex = 'm'
            };

            Console.WriteLine($"{employee.firstname} {employee.lastname}\nAge: {employee.age}\nPESEL: {employee.peselnumber}\nEmployee number: {employee.employeenumber}\nSex: {employee.sex}");

            // Task 2
            char a = 'a';
            char b = 'b';
            char c = 'c';

            char[] letters = [a, b, c];

            foreach (char letter in letters.Reverse())
            {
                Console.WriteLine(letter);
            }

            // Task 3
            static double calculate_diagonal_length(double width = 0, double length = 0)
            {
                int power = 2;

                Console.WriteLine("Type the width of the rectangle's sides:");
                width = double.Parse(Console.ReadLine());
                width = Math.Pow(width, power);

                Console.WriteLine("Type the length of the rectangle's sides:");
                length = double.Parse(Console.ReadLine());
                length = Math.Pow(length, power);

                return Math.Sqrt(width + length);
            }
            Console.WriteLine(calculate_diagonal_length());

            // Task 4
            int a;
            string b;
            double c;
            a = 10;
            b = "Szkoła Dotneta";
            c = 12.5;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
