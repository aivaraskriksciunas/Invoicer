using Invoicer.Api.App.Projects.Entities;

namespace Invoicer.Api.Services;

public class DbInitializer
{
    public static void Initialize(InvoicerContext context)
    {
        if (context.Projects.Any())
        {
            return;
        }

        var projects = new Project[]
        {
            new Project{Name="Creators Inc."},
            new Project{Name="Projectors Inc."},
        };
        context.Projects.AddRange( projects );
        context.SaveChanges();
    }
}
