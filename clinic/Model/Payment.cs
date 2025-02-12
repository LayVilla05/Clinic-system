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
        public string ServiceName { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string  PaymentMethodName { get; set; }

    }
}
