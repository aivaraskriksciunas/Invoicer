
using System.ComponentModel.DataAnnotations;

namespace Invoicer.Api.App.Billables.Dtos;

public class BillableEntryDto
{
    public Guid? Id { get; set; }

    [Required]
    [MaxLength( 255 )]
    public string Title { get; set; } = "";

    public string? Description { get; set; }

    [Required]
    public decimal Amount { get; set; }

    [Required]
    public decimal UnitPrice { get; set; }
}
