using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Models
{
    public class Subtask
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AssignedUserId { get; set; }
        public DateTime DueDate { get; set; }
        public Status Status { get; set; }
    }

}
