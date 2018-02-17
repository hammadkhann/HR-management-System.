using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrObjects
{
    public class Interview
    {
        public int CandidateId { get; set; }
        public int JobPostingId { get; set; }
        public DateTime InterviewDate { get; set; }
        public List<InterviewSchedule> InterviewSchedules { get; set; } //1 hour with Account Manager, 1 hour with General Manager, 1 hour with HR.
    }
}
