using Invoicer.Api.App.Projects.Dtos;
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

    [HttpPost]
    public async Task<ActionResult<Project>> Create( [FromBody]ProjectDto project )
    {
        if (!ModelState.IsValid)
        {
            return BadRequest( ModelState );
        }

        return Ok( await service.Add( project ) );
    }

    [HttpPatch("{id}")]
    public async Task<ActionResult<Project>> Update( int id, [FromBody]ProjectDto model )
    {
        var entity = await service.Find( id );
        if ( entity == null )
        {
            return NotFound();
        }

        if ( !ModelState.IsValid )
        {
            return BadRequest( ModelState );
        }

        return Ok( await service.Update( entity, model ) );
    }
}
