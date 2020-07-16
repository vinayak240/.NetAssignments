using System;
using System.Collections.Generic;

namespace EmployeeService.Models
{
    public partial class Projects
    {
        public Projects()
        {
            Employees = new HashSet<Employees>();
        }

        public string Pid { get; set; }
        public string Pname { get; set; }

        public virtual ICollection<Employees> Employees { get; set; }
    }
}
