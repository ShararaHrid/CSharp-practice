using System;
using Educational_Institute;

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();
        List<Course> courses = new List<Course>();

        // Creating teachers
        Teacher teacher1 = new Teacher("T101", "Dr. Smith");
        Teacher teacher2 = new Teacher("T102", "Prof. Johnson");

        // Creating courses
        Course course1 = new Course("CSE101", "Introduction to Programming", teacher1);
        Course course2 = new Course("CSE102", "Data Structures", teacher2);
        Course course3 = new Course("CSE103", "Database Systems", teacher1);

        courses.AddRange(new[] { course1, course2, course3 });

        // Creating students
        Student student1 = new Student("Alice");
        Student student2 = new Student("Bob");

        students.AddRange(new[] { student1, student2 });

        // Creating StudentService instance
        StudentService studentService = new StudentService(students, courses);

        // Enrolling students in courses using IDs
        studentService.AddCourse(student1.StudentID, course1.CourseID);
        studentService.AddCourse(student1.StudentID, course2.CourseID);
        studentService.AddCourse(student2.StudentID, course2.CourseID);
        studentService.AddCourse(student2.StudentID, course3.CourseID);

        // Updating course
        studentService.UpdateCourse(student1.StudentID, course1.CourseID, course3.CourseID);

        // Getting student information
        studentService.GetStudentInfo(student1.StudentID);
        studentService.GetStudentInfo(student2.StudentID);
    }

}
