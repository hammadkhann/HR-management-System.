using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrObjects
{
    public class Candidate
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string ResumeFilePath { get; set; }
        public int JobPostingId { get; set; }
        public int CandidateId { get; set; }
        public string Status { get; set; }
    }
}
