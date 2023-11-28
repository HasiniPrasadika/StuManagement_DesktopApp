using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_management_system.Models
{
    public class Student
    {
        [Key]
        public string StuRegNo { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int PhoneNo { get; set; }

        public double Gpa { get; set; }

        public ObservableCollection<Enrollment> Enrollments { get; set; }

        public Student() { }


    }
}
