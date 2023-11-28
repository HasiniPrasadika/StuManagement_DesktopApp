using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_management_system.Models
{
    public class Module
    {
        [Key]
        public string ModCode { get; set; }

        public string ModName { get; set; }

        public int Credit { get; set; }

        

        public ObservableCollection<Enrollment> Enrollments { get; set; }

        public ObservableCollection<LecturerModule> LecturerModules { get; set; }

        public Module() { }
    }
}
