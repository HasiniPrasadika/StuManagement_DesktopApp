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
    public partial class AddModuleWindowVM : ObservableObject
    {
        [ObservableProperty]
        public Student selectedStudent1;

        [ObservableProperty]
        public Module selectedModule;

        [ObservableProperty]
        public Module selectedModule1;

        [ObservableProperty]
        public ObservableCollection<Module> listAllModule;

        [ObservableProperty]
        public ObservableCollection<Module> listEnrollModules;

        [ObservableProperty]
        public ObservableCollection<Enrollment> enrollments;

        [ObservableProperty]
        public int mark;

        DatabaseContext moduledb;

        public AddModuleWindowVM()
        {

        }

        public AddModuleWindowVM(Student student)
        {
            SelectedStudent1 = student;
            moduledb = new DatabaseContext();
            ListAllModule = new ObservableCollection<Module>(moduledb.Modules.ToList());
            Enrollments = new ObservableCollection<Enrollment>(moduledb.Enrollments.ToList());
            LoadEnrollModules();
        }

        public void LoadEnrollModules()
        {
            ListEnrollModules = new ObservableCollection<Module>();
            foreach (var M in Enrollments)
            {
                if (M.StudentRegNo == SelectedStudent1.StuRegNo)
                {
                    if (M.Module != null)
                    {
                        ListEnrollModules.Add(M.Module);
                    }
                    else
                        MessageBox.Show("Error");
                }
            }
        }

        [RelayCommand]
        public void Enroll()
        {
            if (SelectedModule != null && SelectedStudent1 != null)
            {
                bool isenrolled = moduledb.Enrollments.Any(sm => sm.ModuleCode == SelectedModule.ModCode && sm.StudentRegNo == SelectedStudent1.StuRegNo);
                if (isenrolled == false)
                {
                    var enrollment = new Enrollment
                    {
                        ModuleCode = SelectedModule.ModCode,
                        StudentRegNo = SelectedStudent1.StuRegNo,
                        Grade = "None"
                    };
                    moduledb.Enrollments.Add(enrollment);
                    moduledb.SaveChanges();
                    ListEnrollModules.Add(enrollment.Module);
                    MessageBox.Show("Done");
                }
                else
                    MessageBox.Show("Already Registed");
            }
            else
                MessageBox.Show("Error");
        }

        [RelayCommand]
        public void Delete()
        {
            if (SelectedModule1 != null && SelectedStudent1 != null)
            {
                bool isenrolled = moduledb.Enrollments.Any(sm => sm.ModuleCode == SelectedModule1.ModCode && sm.StudentRegNo == SelectedStudent1.StuRegNo);
                if (isenrolled)
                {
                    var smToDelete = moduledb.Enrollments.FirstOrDefault(sm => sm.ModuleCode == SelectedModule1.ModCode && sm.StudentRegNo == SelectedStudent1.StuRegNo);
                    _ = moduledb.Enrollments.Remove(smToDelete);
                    moduledb.SaveChanges();
                    MessageBox.Show("Deleted..!");
                    ListEnrollModules.Remove(SelectedModule1);
                }
            }
        }
    }
}
