using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic.Model
{
    public class PatientServices
    {
        public int PatientService { get; set; }
        public int PatientsId { get; set; }
        public int ServiceId { get; set; }
        public int DoctorId { get; set; }
        public DateTime Date { get; set; }
        public string  Status { get; set; }
        public Decimal Price { get; set; }
        public string  PatientName { get; set; }
        public string ServiceName { get; set; }
        public string DoctorName { get; set; }

    }
}
