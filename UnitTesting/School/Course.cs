using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Course
    {
        private List<Student> students = new List<Student>();

        public Student[] Students
        {
            get { return this.students.ToArray(); }
        }

        public void AddStudent(Student student)
        {
            if (this.students.Count >=  Constants.MaxStudentsInCourse)
                throw new ArgumentOutOfRangeException("Count", student, String.Format(
                    "The student couldn't be added, because the number of students shouldn't exeed {0}!", Constants.MaxStudentsInCourse));

            if (this.students.Exists(s => s.ID == student.ID))
                throw new ArgumentException(String.Format("A student with Id {0} already exists in the course!", student.ID));

            this.students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            var studentInd = this.students.IndexOf(student);
            if (studentInd < 1)
                throw new ArgumentException("The student couldn't be removed from the course, because he is not in the course");

        }
    }
}
