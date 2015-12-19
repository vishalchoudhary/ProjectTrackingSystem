using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTS.Core.Model
{
    public class Project
    {
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        public Nullable<DateTime> StartDate { get; set; }
        public Nullable<DateTime> EndDate { get; set; }
        public string ClientName { get; set; }

        public virtual List<UserStory> UserStories { get; set; }
    }
}
