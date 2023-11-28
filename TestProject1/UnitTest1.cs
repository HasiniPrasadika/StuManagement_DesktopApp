using Student_management_system.Models;
using System.Collections.ObjectModel;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        
        public void Student_Initialization_ShouldBeSuccessful()
        {
            // Arrange
            var student = new Student();

            // Act
            student.StuRegNo = "S001";
            student.FirstName = "John";
            student.LastName = "Doe";
            student.PhoneNo = 123456789;
            student.Gpa = 3.5;
            student.Enrollments = new ObservableCollection<Enrollment>();

            // Assert
            student.StuRegNo.Should().Be("S001");
            student.FirstName.Should().Be("John");
            student.LastName.Should().Be("Doe");
            student.PhoneNo.Should().Be(123456789);
            student.Gpa.Should().Be(3.5);
            student.Enrollments.Should().NotBeNull();
        }
    }
}