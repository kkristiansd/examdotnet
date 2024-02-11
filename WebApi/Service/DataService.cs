using WebApi.Models;

namespace WebApi.Service
{
    public class DataService : IDataService
    {
        private List<Project> _projects;
        

        public DataService()
        {
            Data();
        }

        private void Data()
        {
            _projects = new List<Project>
            {
                new Project
                {
                    Id = 1,
                    Title = "Project A",
                    Status = "In Progress",
                    Responsible = "John Doe",
                    userStories = new List<UserStory>
                    {
                        new UserStory { Id = 1, Description = "Implement feature X", Estimate = 5 },
                        new UserStory { Id = 2, Description = "Fix bug in module Y", Estimate = 3 }
                    }
                },
                new Project
                {
                    Id = 2,
                    Title = "Project B",
                    Status = "Completed",
                    Responsible = "Jane Smith",
                    userStories = new List<UserStory>
                    {
                        new UserStory { Id = 3, Description = "Refactor codebase", Estimate = 8 },
                        new UserStory { Id = 4, Description = "Write documentation", Estimate = 2 }
                    }
                }
                // Add more projects and user stories as needed
            };
        }

        public List<Project> GetAllProjects()
        {
            return _projects;
        }

        public Project GetProjectById(int projectId)
        {
            return new Project();
        }

        public void CreateProject(Project project)
        {
            // Set the Project Id (you may use your logic to set the Id)
            project.Id = _projects.Count + 1;

            // Add the new project to the list
            _projects.Add(project);
        }

        public void AddUserStoryToProject(int projectId, UserStory userStory)
        {
            // Find the project by Id
            var project = _projects.Find(p => p.Id == projectId);

            if (project != null)
            {
                // Set the UserStory Id (you may use your logic to set the Id)
                userStory.Id = project.userStories.Count + 1;

                // Add the new user story to the project
                project.userStories.Add(userStory);
            }
            else
            {
                // Handle the case where the project with the specified Id is not found
                // You may throw an exception or handle it as needed
            }
        }
    }
}