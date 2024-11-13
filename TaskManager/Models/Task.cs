using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Task = TaskManager.Models.Task; // Alias to resolve ambiguity

namespace TaskManager.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AssignedUserId { get; set; }
        public DateTime DueDate { get; set; }
        public Status Status { get; set; }
        public List<Subtask> Subtasks { get; set; } = new List<Subtask>();
    }

}
