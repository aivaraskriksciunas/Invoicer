namespace Invoicer.Api.App.Projects.Entities;

public class Project
{
    public Guid Id { get; set; } = Guid.CreateVersion7();

    public string? Name { get; set; }
}
