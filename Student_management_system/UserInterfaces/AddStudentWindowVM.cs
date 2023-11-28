using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Student_management_system.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Student_management_system.UserInterfaces
{
    public partial class AddStudentWindowVM : ObservableObject
    {
        [ObservableProperty]
        public string title;

        [ObservableProperty]
        public string firstName;

        [ObservableProperty]
        public string lastName;

        [ObservableProperty]
        public string regNo;

        [ObservableProperty]
        public string address;

        [ObservableProperty]
        public int phoneNo;

        public Action CloseAction { get; internal set; }

        public Student currentStudent { get; private set; }

        public bool IsSaved;

        public AddStudentWindowVM(Student student)
        {
            currentStudent = student;
            firstName = student.FirstName;
            lastName = student.LastName;
            regNo = student.StuRegNo;
            
            phoneNo = student.PhoneNo;
        }

        public AddStudentWindowVM()
        {

        }

        [RelayCommand]
        public void Save()
        {
            if (currentStudent == null)
            {
                currentStudent = new Student()
                {
                    FirstName = FirstName,
                    LastName = LastName,
                    StuRegNo = RegNo,
                    
                    PhoneNo = PhoneNo
                };

                CloseAction();
                MessageBox.Show("Sucessfully added Student");
            }

            else
            {
                currentStudent.FirstName = FirstName;
                currentStudent.LastName = LastName;
                currentStudent.StuRegNo = RegNo;
                
                currentStudent.PhoneNo = PhoneNo;

                IsSaved = true;

                CloseAction();
                MessageBox.Show("Sucessfully Edit Student");
            }
        }
    }
}
