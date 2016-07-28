using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Student
    {
        #region Fields

        private string name;
        private int studentId;

        #endregion

        #region Constructors

        public Student(string name, int studentId)
        {
            this.Name = name;
            this.ID = studentId;
        }

        #endregion

        #region Properties

        public string Name 
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("The student nameshouldn't be null or empty");

                this.name = value;
            }
        }

        public int ID
        {
            get { return this.studentId; }

            set
            {
                if (value < Constants.MinStudentId || value > Constants.MaxStudentId)
                    throw new ArgumentOutOfRangeException("ID", value,
                        String.Format("The student id should be between {0} and {1}", Constants.MinStudentId, Constants.MaxStudentId));

                this.studentId = value;
            }
        }

        #endregion

        #region Methods

        public override bool Equals(object obj)
        {
            var secondStudent = obj as Student;
            if (this.ID != secondStudent.ID)
                return false;

            if (String.Compare(this.Name, secondStudent.Name, true) != 0)
                return false;

            return true;
        }

        #endregion
    }
}
