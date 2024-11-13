using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Models;

namespace TaskManager.Services
{
    public interface ISubtaskService
    {
        Subtask CreateSubtask(int taskId, string title, int assignedUserId, DateTime dueDate);
        void DeleteSubtask(int subtaskId);
        Subtask GetSubtaskById(int subtaskId);
        List<Subtask> GetSubtasksByTaskId(int taskId);
        void UpdateSubtaskStatus(int subtaskId, Status status);
    }

}
