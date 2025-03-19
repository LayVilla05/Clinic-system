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
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public string Specialization { get; set; }
        public string Phone { get; set; }
        public TimeSpan StartTime { get ; set; }
        public TimeSpan EndTime { get ; set; }
        
    }
    public class DoctorAvailables
    {
        public int AvailableId { get; set; }
        public string AvailableDay { get; set; }
        public int DoctorId { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }

    }
}
