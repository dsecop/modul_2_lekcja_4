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

            // Task 5
            Console.WriteLine("Please complete user data.");
            Console.Write("User first name: ");
            string firstname = Console.ReadLine();

            Console.Write("User last name: ");
            string lastname = Console.ReadLine();

            Console.Write("User phone number: ");
            string phonenumber = Console.ReadLine();
             
            Console.Write("User email address: ");
            string email = Console.ReadLine(); 

            Console.Write("User height (cm): ");
            double height = double.Parse(Console.ReadLine()); 

            Console.Write("User weight (kg): ");
            double weight = double.Parse(Console.ReadLine()); 

            Console.Write("User age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"{firstname} {lastname}");
            Console.WriteLine($"Phone number: {phonenumber}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Height: {height} cm");
            Console.WriteLine($"Height: {weight} kg");
            Console.WriteLine($"Age: {age}");
        }
    }
}
