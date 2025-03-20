using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic.Model
{
    public  class Payment
    {
        public int PaymentId { get; set; }
        public int AppointmentId { get; set; }
        public decimal AmountPaid { get; set; }
        public DateTime PaymentDate { get; set; }
        public string  PaymentMethod { get; set; }
        public decimal TotalCost { get; set; }
        public string status { get; set; }


    }
}
