using Invoicer.Api.App.Projects.Dtos;
using Invoicer.Api.App.Projects.Entities;
using Invoicer.Api.App.Projects.Mappers;
using Invoicer.Api.Common.EntityServices;
using Invoicer.Api.Services;

namespace Invoicer.Api.App.Projects.Services;

public class ProjectsService : BaseEntityService<Project, int>
{
    public ProjectsService( InvoicerContext context ) : base( context ) {}

    public async Task<Project> Add(ProjectDto model)
    {
        var entity = model.ToEntity();
        await db.AddAsync( entity );
        await db.SaveChangesAsync();

        return entity;
    }

    public async Task<Project> Update(Project project, ProjectDto model)
    {
        project.ApplyUpdate( model );
        db.Update( project );
        await db.SaveChangesAsync();

        return project;
    }
}
