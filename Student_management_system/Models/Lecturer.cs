using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_management_system.Models
{
    public class Lecturer
    {
        [Key]
        public string LecId { get; set; }

        public string FirstNamel { get; set; }

        public string LastNamel { get; set; }

        public string ModCodel { get; set; }

        public int PhoneNol { get; set; }

        

        public ObservableCollection<LecturerModule> LecturerModules { get; set; }

        public Lecturer() { }


    }
}
