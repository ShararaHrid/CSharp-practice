using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educational_Institute
{
    public class Teacher
    {
        public string TeacherID { get; set; }
        public string Name { get; set; }

        public Teacher(string teacherID, string name)
        {
            TeacherID = teacherID;
            Name = name;
        }
    }
}
