using PracticaFinal.Controllers;
using PracticaFinal.Models;
using PracticaFinal.Services;
using Moq;

namespace PracticaFinal.Tests
{
    public class StudentControllerTests
    {
        [Fact]
        public void Student_withValidCIAndOver51Nota_IsAprob()
        {
            // Arrange
            var studentService = new Mock<IStudentService>();
            StudentController studentController = new StudentController(studentService.Object);
            // var student = new Student { CI = 1, Nombre = "Alice", Nota = 60 };
            studentService.Setup(s => s.IsAprob(1)).Returns(
                true
            );

            /*
            StudentService studentService = new StudentService();
            StudentController studentController = new StudentController(studentService);
            */

            // Act
            Boolean result = studentController.EvaluateStudentIsAprob(1);

            // Assert
            Assert.True(result);
        }
    }
}