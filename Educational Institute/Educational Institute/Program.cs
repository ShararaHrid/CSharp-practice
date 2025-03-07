using System;
using Educational_Institute;

class Program
{
    static void Main()
    {
        // Creating teachers
        Teacher teacher1 = new Teacher("T101", "Dr. Smith");
        Teacher teacher2 = new Teacher("T102", "Prof. Johnson");

        // Creating courses
        Course course1 = new Course("CSE101", "Introduction to Programming", teacher1);
        Course course2 = new Course("CSE102", "Data Structures", teacher2);
        Course course3 = new Course("CSE103", "Database Systems", teacher1);

        // Creating students
        Student student1 = new Student("Alice");
        Student student2 = new Student("Bob");

        // Enrolling students in courses
        student1.AddCourse(course1);
        student1.AddCourse(course2);
        student2.AddCourse(course2);
        student2.AddCourse(course3);

        // Updating course
        student1.UpdateCourse(course1, course3);

        // Getting student information
        student1.GetStudentInfo();
        student2.GetStudentInfo();
    }
}
