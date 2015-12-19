using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTS.Core.Model
{
    public class ProjectTask
    {
        public int ProjectTaskID { get; set; }
        public Nullable<int> AssignedTo { get; set; }
        public Nullable<DateTime> TaskStartDate { get; set; }
        public Nullable<DateTime> TaskEndDate { get; set; }
        public Nullable<int> TaskCompletion { get; set; }
        public int UserStoryID { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual UserStory UserStory { get; set; }
        public virtual List<ManagerComment> ManagerComments { get; set; }
    }
}
