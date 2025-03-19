using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinic.Model
{
    public class DoctorAvailable
    {
        public int AvailableId { get; set; }
        public string AvailableDay { get; set; }
        public int DoctorId { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }
      
    }
}
