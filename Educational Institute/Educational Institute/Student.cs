using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educational_Institute
{
    class Student
    {
        private static int studentCounter = 1000;
        public string StudentID { get; }
        public string Name { get; set; }
        public List<Course> EnrolledCourses { get; set; }

        public Student(string name)
        {
            StudentID = "S" + studentCounter++;
            Name = name;
            EnrolledCourses = new List<Course>();
        }
    }
}
