using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTS.Core.Model
{
    public class UserStory
    {
        public int UserStoryID { get; set; }
        public string Story { get; set; }
        public int ProjectID { get; set; }

        public virtual Project Projects { get; set; }
        public virtual List<ProjectTask> ProjectTasks { get; set; }
        
    }
}
