using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBuilder.Lib
{
    public abstract class EducationBuilder
    {
        public virtual void AssignTeacher(string teacher) { }
        public virtual void InviteStudents(string student) { }
        public virtual void ProcessStudentFeedback(string feedback) { }

        public abstract IEducation Education { get; }
    }
}
