using System;

namespace Git
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student 
                { 
                FirstName = "Иван",
                LastName = "Железняк",
                Age = 30
            };

            Console.WriteLine(student);

            Console.ReadKey();
        }
    }
}
