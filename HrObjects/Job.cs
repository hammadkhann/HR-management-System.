using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrObjects
{
    public class Job
    {
        public DateTime JobPostingDate { get; set; }
        public string JobDescription { get; set; }
        public string JobTitle { get; set; }
        public Department JobDepartment { get; set; }
        public List<SkillsWithExperience> SkillsWithExperience { get; set; }
        public int JobPostingId { get; set; }
        public int HiringManagerId { get; set; }
        public EmployeeType CandidateType { get; set; }
        public string HiringManager { get; set; }
        public string Status { get; set; }
    }
}
