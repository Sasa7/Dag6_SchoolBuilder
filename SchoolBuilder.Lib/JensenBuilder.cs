using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBuilder.Lib
{
    public class JensenBuilder: EducationBuilder
    {
        IEducation _education;

        public JensenBuilder(IEducation education)
        {
            _education = education;
        }
        public override IEducation Education
        {
            get { return _education; }
        }

        public override void AssignTeacher(string teacher)
        {
            _education.TeacherName = teacher;
        }

        public override void InviteStudents(string student)
        {
            _education.Student = student;
        }

        public override void ProcessStudentFeedback(string feedback)
        {
            _education.Feedback = feedback;
        }
    }
}
