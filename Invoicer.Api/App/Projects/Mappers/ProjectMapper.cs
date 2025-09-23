using Invoicer.Api.App.Projects.Dtos;
using Invoicer.Api.App.Projects.Entities;
using Riok.Mapperly.Abstractions;

namespace Invoicer.Api.App.Projects.Mappers;

[Mapper]
public static partial class ProjectMapper
{
    [MapperIgnoreTarget(nameof(Project.Id))]
    public static partial Project ToEntity( this ProjectDto model );

    [MapperIgnoreSource(nameof(Project.Id))]
    public static partial ProjectDto ToDto( this Project entity );

    public static partial void ApplyUpdate( [MappingTarget] this Project entity, ProjectDto model );
}
