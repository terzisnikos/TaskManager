using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Task> Tasks { get; set; } = new List<Task>();

        // Calculated property for overall project completion rate
        public double CompletionRate
        {
            get
            {
                int totalSubtasks = Tasks.Sum(t => t.Subtasks.Count);
                int completedSubtasks = Tasks.Sum(t => t.Subtasks.Count(st => st.Status == Status.Completed));

                return totalSubtasks == 0 ? 0 : (double)completedSubtasks / totalSubtasks * 100;
            }
        }
    }

}
