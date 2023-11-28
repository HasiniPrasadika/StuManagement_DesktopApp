using CommunityToolkit.Mvvm.ComponentModel;
using Student_management_system.Database;
using Student_management_system.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_management_system.UserInterfaces
{
    public partial class ResultWindowVM : ObservableObject
    {
        [ObservableProperty]
        public Student selectedStudent3;

        [ObservableProperty]
        public ObservableCollection<Module> listEnrMod;

        [ObservableProperty]
        public ObservableCollection<Module> listMod;

        [ObservableProperty]
        public ObservableCollection<Enrollment> listSM;

        [ObservableProperty]
        public ObservableCollection<Enrollment> listGrade;

        DatabaseContext dbcontext;

        public ResultWindowVM() { }

        public ResultWindowVM(Student student)
        {
            SelectedStudent3 = student;
            dbcontext = new DatabaseContext();
            ListSM = new ObservableCollection<Enrollment>(dbcontext.Enrollments);
            ListMod = new ObservableCollection<Module>(dbcontext.Modules.ToList());
            LoadGradeList();
            LoadRegMod();
        }

        public void LoadGradeList()
        {
            ListGrade = new ObservableCollection<Enrollment>();
            foreach (var sm in ListSM)
            {
                if (sm.StudentRegNo == SelectedStudent3.StuRegNo)
                {
                    ListGrade.Add(sm);
                }
            }
        }

        public void LoadRegMod()
        {
            ListEnrMod = new ObservableCollection<Module>();
            foreach (var sm in ListSM)
            {
                if (sm.StudentRegNo == SelectedStudent3.StuRegNo)
                {
                    if (sm.ModuleCode != null)
                    {
                        foreach (var m in ListMod)
                        {
                            if (m.ModCode == sm.ModuleCode)
                            {
                                ListEnrMod.Add(m);
                            }
                        }
                    }
                }
            }
        }

    }
}
