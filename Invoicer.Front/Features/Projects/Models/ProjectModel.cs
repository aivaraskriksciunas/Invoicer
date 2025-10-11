using System.ComponentModel.DataAnnotations;

namespace Invoicer.Front.Features.Projects.Models;

public class ProjectModel
{
    public Guid? Id { get; set; }

    [Required]
    [MaxLength( 100 )]
    [MinLength( 3 )]
    public string? Name { get; set; }
}
