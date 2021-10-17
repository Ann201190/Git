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
            Console.ReadKey();
        }
    }
}
