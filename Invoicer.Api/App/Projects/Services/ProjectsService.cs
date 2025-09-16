using Invoicer.Api.App.Projects.Entities;
using Invoicer.Api.Common.Repositories;
using Invoicer.Api.Services;

namespace Invoicer.Api.App.Projects.Services;

public class ProjectsService : BaseEntityService<Project, int>
{
    public ProjectsService( InvoicerContext context ) : base( context ) {}
}
