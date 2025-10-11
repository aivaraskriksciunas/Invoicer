using Invoicer.Api.App.Billables.Entities;
using Invoicer.Api.App.Projects.Entities;
using Microsoft.EntityFrameworkCore;

namespace Invoicer.Api.Services;

public class InvoicerContext : DbContext
{
    public InvoicerContext(DbContextOptions<InvoicerContext> options)
        : base(options)
    {}

    public DbSet<Project> Projects { get; set; }

    public DbSet<BillableEntry> BillableEntries { get; set; }
}
