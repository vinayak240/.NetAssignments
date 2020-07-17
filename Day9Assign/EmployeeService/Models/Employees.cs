using System;
using System.Collections.Generic;

namespace EmployeeService.Models
{
    public partial class Employees
    {
        public string Eid { get; set; }
        public string Ename { get; set; }
        public DateTime? Joindate { get; set; }
        public string Pid { get; set; }

        public virtual Projects P { get; set; }
    }
}
