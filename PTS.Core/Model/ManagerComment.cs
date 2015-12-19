using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTS.Core.Model
{
    public class ManagerComment
    {
        public int ManagerCommentID { get; set; }
        public string Comments { get; set; }
        public int ProjectTaskID { get; set; }

        public virtual ProjectTask ProjectTask { get; set; }
    }
}
