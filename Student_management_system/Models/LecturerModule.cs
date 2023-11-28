using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_management_system.Models
{
    public class LecturerModule
    {
        public string LecturerId { get; set; }

        public Lecturer Lecturer { get; set; }

        public string ModCodelec { get; set; }
        
        public Module Module { get; set; }
                        

        public LecturerModule() { }
    }
}
