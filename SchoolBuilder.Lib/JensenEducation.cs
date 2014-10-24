using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBuilder.Lib
{
    public class JensenEducation: IEducation
    {
        public string EducationName
        {
            get { return "Jensen"; }
        }

        public JensenEducation(string teacher, string student, string feedback)
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
