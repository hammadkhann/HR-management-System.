using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrObjects
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Employee ImmediateBoss { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public int EmployeeId { get; set; }

        public string Name { get { return string.Format("{0} {1}", FirstName, LastName); } }        
    }

    
}
        