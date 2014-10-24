using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBuilder.Lib
{
    public class NackademinEducation: IEducation
    {
        public string EducationName
        {
            get { return "Nackademin"; }
        }

        public NackademinEducation(string teacher, string student, string feedback)
        {
            TeacherName = teacher;
            Student = student;
            Feedback = feedback;
        }

        public string TeacherName
        {
            get
            ;
            set
            ;
        }

        public string Student
        {
            get
            ;
            set
            ;
        }

        public string Feedback
        {
            get
            ;
            set
            ;
        }
    }
}
