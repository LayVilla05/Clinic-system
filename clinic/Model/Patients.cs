using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic.Model
{
    public class Patients
    {
   
        public int PatientId{ get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public DateTime Dob { get; set; }
        public string Phone { get; set; }
    }
}
