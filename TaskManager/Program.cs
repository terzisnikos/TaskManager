using System;
using System.Collections.Generic;
using System.Linq;
using TaskManager.Models;
using Task = TaskManager.Models.Task; // Alias to resolve ambiguity


namespace TaskManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a project
            Project project = new Project
            {
                Id = 1,
                Name = "Website Redesign",
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddMonths(2)
            };

            Console.WriteLine($"Created Project: {project.Name}, Start Date: {project.StartDate.ToShortDateString()}, End Date: {project.EndDate.ToShortDateString()}");

            // Adding a task to the project
            Task task1 = new Task
            {
                Id = 1,
                Title = "Design Phase",
                AssignedUserId = 101,
                DueDate = DateTime.Now.AddDays(15),
                Status = Status.Pending
            };
            project.Tasks.Add(task1);

            Console.WriteLine($"Added Task: {task1.Title}, Assigned User: {task1.AssignedUserId}, Due Date: {task1.DueDate.ToShortDateString()}, Status: {task1.Status}");

            // Adding subtasks to the task
            Subtask subtask1 = new Subtask
            {
                Id = 1,
                Title = "Create Wireframes",
                AssignedUserId = 102,
                DueDate = DateTime.Now.AddDays(7),
                Status = Status.Pending
            };

            Subtask subtask2 = new Subtask
            {
                Id = 2,
                Title = "Review Wireframes",
                AssignedUserId = 103,
                DueDate = DateTime.Now.AddDays(10),
                Status = Status.Pending
            };

            task1.Subtasks.Add(subtask1);
            task1.Subtasks.Add(subtask2);

            Console.WriteLine($"Added Subtasks to {task1.Title}:");
            Console.WriteLine($" - {subtask1.Title}, Assigned User: {subtask1.AssignedUserId}, Due Date: {subtask1.DueDate.ToShortDateString()}, Status: {subtask1.Status}");
            Console.WriteLine($" - {subtask2.Title}, Assigned User: {subtask2.AssignedUserId}, Due Date: {subtask2.DueDate.ToShortDateString()}, Status: {subtask2.Status}");

            // Updating status of a subtask
            subtask1.Status = Status.Completed;
            Console.WriteLine($"Updated Subtask Status: {subtask1.Title} is now {subtask1.Status}");

            // Checking completion rate for the project
            Console.WriteLine($"Project Completion Rate: {project.CompletionRate}%");

            // Completing all subtasks
            subtask2.Status = Status.Completed;
            Console.WriteLine($"Updated Subtask Status: {subtask2.Title} is now {subtask2.Status}");

            // Recalculating completion rate
            Console.WriteLine($"Project Completion Rate after completing all subtasks: {project.CompletionRate}%");
        }
    }
}
