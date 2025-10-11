using Invoicer.Api.App.Projects.Entities;
using Riok.Mapperly.Abstractions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Invoicer.Api.App.Billables.Entities;

public class BillableEntry
{
    [MapperIgnore]
    public Guid Id { get; set; } = Guid.CreateVersion7();

    [Required]
    [MaxLength( 255 )]
    public string Title { get; set; } = "";

    [Column(TypeName = "text")]
    public string? Description { get; set; }

    [Column(TypeName = "numeric(20,2)")]
    public decimal Amount { get; set; }

    [Column(TypeName = "numeric(20,2)" )]
    public decimal UnitPrice { get; set; }

    [Required]
    public Project Project { get; set; }
}
