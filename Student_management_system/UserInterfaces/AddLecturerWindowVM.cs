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
    public partial class AddLecturerWindowVM : ObservableObject
    {
        [ObservableProperty]
        public string titlel;

        [ObservableProperty]
        public string firstNamel;

        [ObservableProperty]
        public string lastNamel;

        [ObservableProperty]
        public string lecId;

        [ObservableProperty]
        public string modCodel;

        [ObservableProperty]
        public int phoneNol;

        public Action CloseAction { get; internal set; }

        public Lecturer currentLecturer { get; private set; }

        public bool IsSaved;

        public AddLecturerWindowVM(Lecturer lecturer)
        {
            currentLecturer = lecturer;
            firstNamel = lecturer.FirstNamel;
            lastNamel = lecturer.LastNamel;
            lecId = lecturer.LecId;
            modCodel = lecturer.ModCodel;
            PhoneNol = lecturer.PhoneNol;
        }

        public AddLecturerWindowVM()
        {

        }

        [RelayCommand]
        public void Save()
        {
            if (currentLecturer == null)
            {
                currentLecturer= new Lecturer()
                {
                    FirstNamel = FirstNamel,
                    LastNamel = LastNamel,
                    LecId = LecId,
                    ModCodel = ModCodel,
                    PhoneNol = PhoneNol

                };

                CloseAction();
                MessageBox.Show("Sucessfully added Lecturer");
            }

            else
            {
                currentLecturer.FirstNamel = FirstNamel;
                currentLecturer.LastNamel = LastNamel;
                currentLecturer.LecId = LecId;
                currentLecturer.ModCodel = ModCodel;
                currentLecturer.PhoneNol = PhoneNol;

                IsSaved = true;

                CloseAction();
                MessageBox.Show("Sucessfully Edit Lecturer");
            }
        }
    }
}
