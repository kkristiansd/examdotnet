namespace WebApi.Service;

using System.Collections.Generic;
using WebApi.Models;

public interface IDataService
{
    List<Project> GetAllProjects();
    Project GetProjectById(int projectId);
    void CreateProject(Project project);
    void AddUserStoryToProject(int projectId, UserStory userStory);
}

