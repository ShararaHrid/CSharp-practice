using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educational_Institute
{
    class StudentService
    {
        public void AddCourse(Student student, Course course)
        {
            if (!student.EnrolledCourses.Contains(course))
            {
                student.EnrolledCourses.Add(course);
                Console.WriteLine($"{student.Name} enrolled in {course.CourseName}.");
            }
            else
            {
                Console.WriteLine($"{student.Name} is already enrolled in {course.CourseName}.");
            }
        }

        public void UpdateCourse(Student student, Course oldCourse, Course newCourse)
        {
            if (student.EnrolledCourses.Contains(oldCourse))
            {
                student.EnrolledCourses.Remove(oldCourse);
                student.EnrolledCourses.Add(newCourse);
                Console.WriteLine($"{student.Name} updated course {oldCourse.CourseName} to {newCourse.CourseName}.");
            }
            else
            {
                Console.WriteLine($"{student.Name} is not enrolled in {oldCourse.CourseName}.");
            }
        }

        public void GetStudentInfo(Student student)
        {
            Console.WriteLine($"\nStudent ID: {student.StudentID}");
            Console.WriteLine($"Name: {student.Name}");
            Console.WriteLine("Courses Enrolled:");
            if (student.EnrolledCourses.Count == 0)
            {
                Console.WriteLine("No courses enrolled.");
            }
            else
            {
                foreach (var course in student.EnrolledCourses)
                {
                    Console.WriteLine($"- {course.CourseName} (Instructor: {course.Instructor.Name})");
                }
            }
        }
    }
}
