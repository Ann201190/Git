using System;

namespace Git
{
    class Program
    {
        static void Main(string[] args)
        {
            Exam exam = new Exam 
            {
             Name="Физика",
             Date = DateTime.Now
            };

            Console.WriteLine(exam);

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
