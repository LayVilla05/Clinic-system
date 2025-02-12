using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic.Model
{
    public class Appiontment
    {
        
            public int AppointmentId { get; set; }
            public int PatientId { get; set; }
            public int DoctorId { get; set; }
            public DateTime AppointmentDate { get; set; }
            public string Status { get; set; }
            public int ServiceId { get; set; }
            public string Note { get; set; }
        }

    
}
