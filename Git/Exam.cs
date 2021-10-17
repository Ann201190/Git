using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git
{
    class Exam
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Examenator { get; set; }

        public override string ToString()
        {
            return $" {Name}  {Date}";
        }
    }
}
