using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrObjects
{
    public class InterviewDetails
    {        
        public string JobTitle { get; set; }
        public string CandidateName { get; set; }
        public string InterviewDate { get; set; }
        public string Department { get; set; }
         
        public int InterviewId { get; set; }
        public bool IsInterviewCompleted { get; set; }
        public bool IsCandidateSelected { get; set; }
        public bool IsOfferAccepted { get; set; }
        public DateTime JoiningDate { get; set; }
        public string HiringManager { get; set; }
        public string InterviewStatus { get; set; }
        
    }
}
