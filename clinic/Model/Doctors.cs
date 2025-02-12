using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic.Model
{
    public class Doctors
    {
        public int DoctorId { get; set; }
        public string FirstName { get; set; } = String.Empty;
        public string LastName { get; set; }
        public string Specialization { get; set; }
        public string Phone { get; set; }
        public bool isAvailable { get; set; }
    }
}
