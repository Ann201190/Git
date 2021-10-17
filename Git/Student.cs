using System;

namespace Git
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public DateTime DateBirthday { get; set; }


        public override string ToString()
        {
            return $"{FirstName}  {LastName}  {Age}  {DateBirthday}";
        }
    }
}
