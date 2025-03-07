using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educational_Institute
{
    public class Course
    {
        public string CourseID { get; set; }
        public string CourseName { get; set; }
        public Teacher Instructor { get; set; }

        public Course(string courseID, string courseName, Teacher instructor)
        {
            CourseID = courseID;
            CourseName = courseName;
            Instructor = instructor;
        }

        public override string ToString()
        {
            return $"{CourseID}: {CourseName} (Instructor: {Instructor.Name})";
        }
    }
}
