using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Service;

namespace WebApi.Controllers;


    [ApiController]
    [Route("api/[controller]")]
    public class ProjectController : ControllerBase
    {
        private readonly IDataService _dataService;

        public ProjectController(IDataService dataService)
        {
            _dataService = dataService;
        }

        [HttpPost]
        public IActionResult CreateProject([FromBody] Project project)
        {
            _dataService.CreateProject(project);
            return Ok(project);
        }

        [HttpPost("{projectId}/userstory")]
        public IActionResult AddUserStoryToProject(int projectId, [FromBody] UserStory userStory)
        {
            _dataService.AddUserStoryToProject(projectId, userStory);
            return Ok(userStory);
        }

        [HttpGet("{projectId}")]
        public IActionResult GetProjectById(int projectId)
        {
            var project = _dataService.GetProjectById(projectId);

            if (project != null)
            {
                return Ok(project);
            }
            else
            {
                return NotFound($"Project with Id {projectId} not found.");
            }
        }

        [HttpGet]
        public IActionResult GetAllProjects(string statusFilter = null, string responsibleFilter = null)
        {
            var projects = _dataService.GetAllProjects();
            return Ok(projects);
        }
    }
