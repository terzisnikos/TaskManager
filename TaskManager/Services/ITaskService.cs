using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Models;
using Task = TaskManager.Models.Task; // Alias to resolve ambiguity

namespace TaskManager.Services
{
    public interface ITaskService
    {
        Task CreateTask(int projectId, string title, int assignedUserId, DateTime dueDate);
        void DeleteTask(int taskId);
        Task GetTaskById(int taskId);
        List<Task> GetTasksByProjectId(int projectId);
        void UpdateTaskStatus(int taskId, Status status);
    }


}
 