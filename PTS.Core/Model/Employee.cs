using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTS.Core.Model
{
    public class Employee
    {
        public int EmployeeID { get; set; }

        public string EmployeeName { get; set; }
        public string Designation { get; set; }
        public int ManagerID { get; set; }
        public string ContactNo { get; set; }
        public string EMailID { get; set; }
        public string SkillSet { get; set; }

        public virtual List<ProjectTask> ProjectTasks { get; set;}

    }
}
