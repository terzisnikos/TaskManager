using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Models;

namespace TaskManager.Services
{
    public interface IProjectService
    {
        Project CreateProject(string name, DateTime startDate, DateTime endDate);
        void DeleteProject(int projectId);
        Project GetProjectById(int projectId);
        List<Project> GetAllProjects();
        double GetProjectCompletionRate(int projectId);
    }

}
