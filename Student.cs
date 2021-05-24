using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace students
{
    [Serializable]
    public class Student
    {
        public int GradeBookID { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Group { get; set; }
        public int Course { get; set; }
        public int Rating { get; set; }
        public string Notes { get; set; }

        public Student()
        {

        }
    }
}
