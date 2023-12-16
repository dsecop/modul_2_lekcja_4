namespace modul_2_lekcja_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
