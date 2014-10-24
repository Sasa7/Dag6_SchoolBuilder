using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBuilder.Lib
{
    public class ConcreteDirector: EducationDirector
    {
        public override IEducation Build(EducationBuilder builder)
        {
            builder.AssignTeacher(builder.Education.TeacherName);
            builder.InviteStudents(builder.Education.Student);
            builder.ProcessStudentFeedback(builder.Education.Feedback);

            return builder.Education;
        }
    }
}
