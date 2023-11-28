using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Student_management_system.Database;
using Student_management_system.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Student_management_system.UserInterfaces
{
    public partial class StudentWindowVM : ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<Student> listofStudent;

        [ObservableProperty]
        public ObservableCollection<Lecturer> listofLecturer;

        

        [ObservableProperty]
        public Student selectedStudent;

        [ObservableProperty]
        public Lecturer selectedLecturer;

        DatabaseContext studentData;
        DatabaseContext lecturerData;

        public StudentWindowVM()
        {
            studentData = new DatabaseContext();
            lecturerData = new DatabaseContext();
            LoadStudent();
            LoadLecturer();
        }

        private void LoadStudent()
        {
            ListofStudent = new ObservableCollection<Student>(studentData.Students.ToList());
        }
        private void LoadLecturer()
        {
            ListofLecturer = new ObservableCollection<Lecturer>(lecturerData.Lecturers.ToList());
        }

        [RelayCommand]
        public void AddStudent()
        {
            var addstudentwindowvm = new AddStudentWindowVM
            {
                Title = "ADD STUDENT"
            };

            AddStudentWindow addStudentWindow = new AddStudentWindow(addstudentwindowvm);
            addStudentWindow.ShowDialog();

            if (addstudentwindowvm.currentStudent != null)
            {
                studentData.Students.Add(addstudentwindowvm.currentStudent);
                studentData.SaveChanges();
                ListofStudent.Add(addstudentwindowvm.currentStudent);
            }
            else
                return;

        }

        [RelayCommand]
        public void AddLecturer()
        {
            var addlecturerwindowvm = new AddLecturerWindowVM
            {
                Titlel = "ADD LECTURER"
            };

            AddLecturerWindow addLecturerWindow = new AddLecturerWindow(addlecturerwindowvm);
            addLecturerWindow.ShowDialog();

            if (addlecturerwindowvm.currentLecturer != null)
            {
                lecturerData.Lecturers.Add(addlecturerwindowvm.currentLecturer);
                lecturerData.SaveChanges();
                ListofLecturer.Add(addlecturerwindowvm.currentLecturer);
            }
            else
                return;

        }

        [RelayCommand]
        public void EditStudent()
        {
            if (SelectedStudent != null)
            {
                var vm = new AddStudentWindowVM(SelectedStudent);
                vm.Title = "EDIT STUDENT";
                var window = new AddStudentWindow(vm);

                window.ShowDialog();

                if (vm.IsSaved)
                {
                    var studentToUpdate = studentData.Students.FirstOrDefault(u => u.StuRegNo == SelectedStudent.StuRegNo);
                    if (studentToUpdate != null)
                    {
                        studentToUpdate.StuRegNo = vm.currentStudent.StuRegNo;
                        studentToUpdate.FirstName = vm.currentStudent.FirstName;
                        studentToUpdate.LastName = vm.currentStudent.LastName;
                        
                        studentToUpdate.PhoneNo = vm.currentStudent.PhoneNo;

                        studentData.SaveChanges();
                        int index = ListofStudent.IndexOf(SelectedStudent);
                        ListofStudent.RemoveAt(index);
                        ListofStudent.Insert(index, studentToUpdate);
                    }
                }
            }
            else
                MessageBox.Show("Please Select Student");
        }

        [RelayCommand]
        public void EditLecturer()
        {
            if (SelectedLecturer != null)
            {
                var vm = new AddLecturerWindowVM(SelectedLecturer);
                vm.Titlel = "EDIT LECTURER";
                var window = new AddLecturerWindow(vm);

                window.ShowDialog();

                if (vm.IsSaved)
                {
                    var lecturerToUpdate = lecturerData.Lecturers.FirstOrDefault(u => u.LecId == SelectedLecturer.LecId);
                    if (lecturerToUpdate != null)
                    {
                        lecturerToUpdate.LecId = vm.currentLecturer.LecId;
                        lecturerToUpdate.FirstNamel = vm.currentLecturer.FirstNamel;
                        lecturerToUpdate.LastNamel = vm.currentLecturer.LastNamel;
                        lecturerToUpdate.ModCodel = vm.currentLecturer.ModCodel;
                        lecturerToUpdate.PhoneNol = vm.currentLecturer.PhoneNol;

                        lecturerData.SaveChanges();
                        int index = ListofLecturer.IndexOf(SelectedLecturer);
                        ListofLecturer.RemoveAt(index);
                        ListofLecturer.Insert(index, lecturerToUpdate);
                    }
                }
            }
            else
                MessageBox.Show("Please Select Lecturer");
        }

        [RelayCommand]
        public void Delete()
        {
            if (SelectedStudent != null)
            {
                studentData.Remove(SelectedStudent);
                studentData.SaveChanges();
                MessageBox.Show("Student Sucessfuly Deleted");
                ListofStudent.Remove(SelectedStudent);
            }

            else
                MessageBox.Show("Please Select Student");
        }

        [RelayCommand]
        public void Deletelec()
        {
            if (SelectedLecturer != null)
            {
                lecturerData.Remove(SelectedLecturer);
                lecturerData.SaveChanges();
                MessageBox.Show("Lecturer Sucessfuly Deleted");
                ListofLecturer.Remove(SelectedLecturer);
            }

            else
                MessageBox.Show("Please Select Lecturer");
        }

        [RelayCommand]
        public void AddModule()
        {
            if (SelectedStudent != null)
            {
                var vm = new AddModuleWindowVM(SelectedStudent);
                var window = new AddModuleWindow(vm);
                window.ShowDialog();
            }
            else
                MessageBox.Show("Please Select Student");
        }

        [RelayCommand]
        public void AddGrade()
        {
            if (SelectedStudent != null)
            {
                var vm = new AddGradeWindowVM(SelectedStudent);
                var window = new AddGradeWindow(vm);
                window.ShowDialog();
            }
            else
                MessageBox.Show("Please Select Student");
        }

        [RelayCommand]
        public void ShowResult()
        {
            if (SelectedStudent != null)
            {
                var vm = new ResultWindowVM(SelectedStudent);
                var window = new ResultWindow(vm);
                window.ShowDialog();
            }
            else
                MessageBox.Show("Please Select Student");
        }
    }
}
