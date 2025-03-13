using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educational_Institute
{
    class StudentService
    {
        private List<Student> students;
        private List<Course> courses;

        public StudentService(List<Student> students, List<Course> courses)
        {
            this.students = students;
            this.courses = courses;
        }

        public void AddCourse(string studentID, string courseID)
        {
            Student student = students.FirstOrDefault(s => s.StudentID == studentID);
            Course course = courses.FirstOrDefault(c => c.CourseID == courseID);
            
            if (student == null)
            {
                Console.WriteLine("Student not found.");
                return;
            }
            if (course == null)
            {
                Console.WriteLine("Course not found.");
                return;
            }
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

        public void UpdateCourse(string studentID, string oldCourseID, string newCourseID)
        {
            Student student = students.FirstOrDefault(s => s.StudentID == studentID);
            Course oldCourse = courses.FirstOrDefault(c => c.CourseID == oldCourseID);
            Course newCourse = courses.FirstOrDefault(c => c.CourseID == newCourseID);
            
            if (student == null)
            {
                Console.WriteLine("Student not found.");
                return;
            }
            if (oldCourse == null || newCourse == null)
            {
                Console.WriteLine("Invalid course ID.");
                return;
            }
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

        public void GetStudentInfo(string studentID)
        {
            Student student = students.FirstOrDefault(s => s.StudentID == studentID);
            if (student == null)
            {
                Console.WriteLine("Student not found.");
                return;
            }
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
