using Invoicer.Api.App.Projects.Entities;
using Invoicer.Api.App.Projects.Services;
using Microsoft.AspNetCore.Mvc;

namespace Invoicer.Api.App.Projects;

public class ProjectsController : BaseController
{
    private readonly ProjectsService service;

    public ProjectsController(ProjectsService projectsService)
    {
        service = projectsService;
    }

    [HttpGet]
    public async Task<IEnumerable<Project>> List()
    {
        return await service.List();
    }
}
