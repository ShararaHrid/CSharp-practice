using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educational_Institute
{
    public class Student
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

        public void AddCourse(Course course)
        {
            if (!EnrolledCourses.Contains(course))
            {
                EnrolledCourses.Add(course);
                Console.WriteLine($"{Name} enrolled in {course.CourseName}.");
            }
            else
            {
                Console.WriteLine($"{Name} is already enrolled in {course.CourseName}.");
            }
        }

        public void UpdateCourse(Course oldCourse, Course newCourse)
        {
            if (EnrolledCourses.Contains(oldCourse))
            {
                EnrolledCourses.Remove(oldCourse);
                EnrolledCourses.Add(newCourse);
                Console.WriteLine($"{Name} updated course {oldCourse.CourseName} to {newCourse.CourseName}.");
            }
            else
            {
                Console.WriteLine($"{Name} is not enrolled in {oldCourse.CourseName}.");
            }
        }

        public void GetStudentInfo()
        {
            Console.WriteLine($"\nStudent ID: {StudentID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine("Courses Enrolled:");
            if (EnrolledCourses.Count == 0)
            {
                Console.WriteLine("No courses enrolled.");
            }
            else
            {
                foreach (var course in EnrolledCourses)
                {
                    Console.WriteLine($"- {course.CourseName} (Instructor: {course.Instructor.Name})");
                }
            }
        }
    }
}
