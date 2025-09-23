using System.ComponentModel.DataAnnotations;

namespace Invoicer.Api.App.Projects.Dtos;

public class ProjectDto
{
    [Required]
    [StringLength(100)]
    public string? Name { get; set; }
}
