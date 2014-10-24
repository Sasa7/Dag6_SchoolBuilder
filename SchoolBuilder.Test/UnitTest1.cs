using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolBuilder.Lib;

namespace SchoolBuilder.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Jensen_Education()
        {
            //Arrange
            string expectedEducationName = "Jensen";
            string expectedTeacher = "Sasa";
            string expectedStudents = "Benjamin";
            string expectedFeedBack = "Perfekt";

            IEducation education = new JensenEducation("Sasa", "Benjamin", "Perfekt");
            EducationBuilder builder = new JensenBuilder(education);
            EducationDirector director = new ConcreteDirector();

            //Act
            IEducation actual = director.Build(builder);


            //Assert
            Assert.AreEqual(expectedEducationName, actual.EducationName);
            Assert.AreEqual(expectedTeacher, actual.TeacherName);
            Assert.AreEqual(expectedStudents, actual.Student);
            Assert.AreEqual(expectedFeedBack, actual.Feedback);
        }

        [TestMethod]
        public void Test_Nackademin_Education()
        {
            //Arrange
            string expectedEducationName = "Nackademin";
            string expectedTeacher = "Maja";
            string expectedStudents = "Goran";
            string expectedFeedBack = "Bra";

            IEducation education = new NackademinEducation("Maja", "Goran", "Bra");
            EducationBuilder builder = new NackademinBuilder(education);
            EducationDirector director = new ConcreteDirector();

            //Act
            IEducation actual = director.Build(builder);

            //Assert
            Assert.AreEqual(expectedEducationName, actual.EducationName);
            Assert.AreEqual(expectedTeacher, actual.TeacherName);
            Assert.AreEqual(expectedStudents, actual.Student);
            Assert.AreEqual(expectedFeedBack, actual.Feedback);
        }
    }
}
