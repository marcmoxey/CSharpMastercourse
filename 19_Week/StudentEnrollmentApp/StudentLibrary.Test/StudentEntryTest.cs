using StudentLibrary.Logic;
using StudentLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary.Test
{
    [TestClass]
    public class StudentEntryTest
    {

        private StudentService _service;

        [TestInitialize]
        public void Setup()
        {
            _service = new StudentService();
        }

        [TestMethod]
        public void ValidateStudent_WithValidData_ReturnsTrue()
        {
            // Arrange 
            var student = new StudentModel
            {
                FirstName = "John",
                LastName = "Doe",
                courses = new List<CourseModel>
                {
                    new CourseModel { CourseName = "CS227", Credits = 3 }
                }
            };
            bool expected = true;

            // Act
            var actual = _service.ValidateStudent(student);

            // Assert
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void ValidateStudent_WithEmptyFirstName_ReturnsFalse()
        {
            // arrange 
            var student = new StudentModel
            {
                FirstName = "",
                LastName = "Doe",
                courses = new List<CourseModel>
                {
                    new CourseModel { CourseName = "CS255", Credits = 3 }
                }
            };

            bool expected = false;

            // Act 
            var actual = _service.ValidateStudent(student);

            // Assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateStudent_WithEmptyLastName_ReturnsFalse()
        {
            // arrange 
            var student = new StudentModel
            {
                FirstName = "John",
                LastName = "",
                courses = new List<CourseModel>
                {
                    new CourseModel { CourseName = "CS245", Credits = 3 }
                }
            };

            bool expected = false;

            // Act
            var actual = _service.ValidateStudent(student);

            // Assert 
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void ValidateStudent_WithNoCourses_ReturnsFalse()
        {
            // arrange 
            var student = new StudentModel
            {
                FirstName = "John",
                LastName = "Doe",
                courses = new List<CourseModel>()
            };

            bool expected = false;
            // Act
            var actual = _service.ValidateStudent(student);
            // Assert 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateCourse_WithValidData_ReturnsTrue()
        {
            // Arrange 
            var course = new CourseModel
            {
                CourseName = "CS101",
                Credits = 3
            };
            bool expected = true;
            // Act
            var actual = _service.ValidateCourse(course);
            // Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
