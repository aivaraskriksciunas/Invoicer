using System.ComponentModel.DataAnnotations;

namespace Invoicer.Front.App.Projects.Models;

public class ProjectModel
{
    public int? Id { get; }

    [Required]
    [MaxLength(100)]
    [MinLength(3)]
    public string? Name { get; set; }
}
