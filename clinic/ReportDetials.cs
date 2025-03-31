using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic
{
     class ReportDetials
    {
        public ReportDetials(int appointmentId, DateTime appointmentDate, decimal totalCost, decimal amountPaid, string patientName, string doctorName, string serviceName)
        {
            AppointmentId = appointmentId;
            AppointmentDate = appointmentDate;
            TotalCost = totalCost;
            AmountPaid = amountPaid;
            PatientName = patientName;
            DoctorName = doctorName;
            ServiceName = serviceName;
        }

        public int AppointmentId { get; set; }
     
        public DateTime AppointmentDate { get; set; }

        public decimal TotalCost { get; set; }
        public decimal AmountPaid { get; set; }
        public string PatientName { get; set; }
        public string DoctorName { get; set; }
        public string ServiceName { get; set; }
        public decimal ChangePrice { get { return AmountPaid - TotalCost; } }


    }
}
