using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrObjects
{
    public class InterviewSchedule
    {
        public int InterviewerId { get; set; }        
        public DateTime InterviewStartTime { get; set; } //
        public DateTime InterviewEndTime { get; set; } //1 hours.
    }
}
