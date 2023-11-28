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
    public partial class AddGradeWindowVM : ObservableObject
    {
        [ObservableProperty]
        public Student selectedStudent2;

        [ObservableProperty]
        public ObservableCollection<Module> modules;

        [ObservableProperty]
        public ObservableCollection<Module> listEnModule;

        [ObservableProperty]
        public ObservableCollection<Enrollment> listStuModule;

        [ObservableProperty]
        public ObservableCollection<Enrollment> gradeList;

        [ObservableProperty]
        public Module selectedModule1;

        [ObservableProperty]
        public double marks;
        DatabaseContext db;

        public AddGradeWindowVM() { }

        public AddGradeWindowVM(Student student)
        {
            SelectedStudent2 = student;
            db = new DatabaseContext();
            ListStuModule = new ObservableCollection<Enrollment>(db.Enrollments.ToList());
            Modules = new ObservableCollection<Module>(db.Modules.ToList());
            LoadenModules();
            LoadGradeList();

        }

        public void LoadGradeList()
        {
            GradeList = new ObservableCollection<Enrollment>();
            foreach (var sm in ListStuModule)
            {
                if (sm.StudentRegNo == SelectedStudent2.StuRegNo)
                {
                    GradeList.Add(sm);
                }
            }
        }

        public void LoadenModules()
        {
            ListEnModule = new ObservableCollection<Module>();
            foreach (var M in ListStuModule)
            {
                if (M.StudentRegNo == SelectedStudent2.StuRegNo)
                {
                    if (M.ModuleCode != null)
                    {
                        foreach (var m in Modules)
                        {
                            if (m.ModCode.Equals(M.ModuleCode))
                            {
                                ListEnModule.Add(m);
                            }
                        }
                    }
                    else
                        MessageBox.Show("Error10");
                }
            }
        }

        [RelayCommand]
        public void AddGrade()
        {
            foreach (var sm in GradeList)
            {
                if (sm.ModuleCode == SelectedModule1.ModCode)
                {
                    if (Marks >= 85)
                        sm.Grade = "A+";
                    else if (Marks >= 75)
                        sm.Grade = "A";
                    else if (Marks >= 70)
                        sm.Grade = "A-";
                    else if (Marks >= 65)
                        sm.Grade = "B+";
                    else if (Marks >= 60)
                        sm.Grade = "B";
                    else if (Marks >= 55)
                        sm.Grade = "B-";
                    else if (Marks >= 50)
                        sm.Grade = "C+";
                    else if (Marks >= 45)
                        sm.Grade = "C";
                    else if (Marks >= 40)
                        sm.Grade = "C-";
                    else
                        sm.Grade = "E";

                    var studentmoduleToUp = db.Enrollments.FirstOrDefault(sm => sm.StudentRegNo == SelectedStudent2.StuRegNo && sm.ModuleCode == SelectedModule1.ModCode);

                    if (studentmoduleToUp != null)
                    {
                        studentmoduleToUp.Grade = sm.Grade;
                        studentmoduleToUp.Marks = Marks;
                        db.SaveChanges();
                        LoadGradeList();
                    }
                    else
                        MessageBox.Show("Error 200");
                }
                LoadGradeList();
            }
            Marks = 0;
        }

        [RelayCommand]
        public void CalculateGPA()
        {
            if (SelectedStudent2 != null)
            {
                double GPCredit = 0.0;
                double Totalcredit = 0.0;

                foreach (var m in ListEnModule)
                {
                    foreach (var sm in GradeList)
                    {
                        if (m.ModCode == sm.ModuleCode)
                        {
                            int Credit = m.Credit;
                            double GradePoint = 0.0;
                            string Grade = sm.Grade;

                            if (Grade == "A+")
                                GradePoint = 4.0;
                            else if (Grade == "A")
                                GradePoint = 4.0;
                            else if (Grade == "A-")
                                GradePoint = 3.7;
                            else if (Grade == "B+")
                                GradePoint = 3.3;
                            else if (Grade == "B")
                                GradePoint = 3.0;
                            else if (Grade == "B-")
                                GradePoint = 2.7;
                            else if (Grade == "C+")
                                GradePoint = 2.3;
                            else if (Grade == "C")
                                GradePoint = 2.0;
                            else if (Grade == "C-")
                                GradePoint = 1.7;
                            else
                                GradePoint = 0.0;

                            GPCredit += GradePoint * Credit;
                            Totalcredit += Credit;

                        }
                    }
                }

                double GPA = Math.Round((GPCredit / Totalcredit), 4);

                var ToUpStudent = db.Students.FirstOrDefault(s => s.StuRegNo == SelectedStudent2.StuRegNo);

                if (ToUpStudent != null)
                {
                    ToUpStudent.Gpa = GPA;
                    db.SaveChanges();
                    MessageBox.Show("GPA Calculated..!");
                }
                else
                    MessageBox.Show("Error 100");
            }
        }
    }
}
