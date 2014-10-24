using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolBuilder.Lib
{
    public interface IEducation
    {
        string EducationName { get; }
        string TeacherName { get; set; }
        string Student { get; set; }
        string Feedback { get; set; }
    }
}
