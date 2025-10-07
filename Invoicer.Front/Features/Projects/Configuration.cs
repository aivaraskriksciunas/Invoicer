using Invoicer.Front.Features.Projects.Services;

namespace Invoicer.Front.Features.Projects;

public class Configuration
{
    public static void ConfigureServices(IServiceCollection services)
    {
        //services.AddBackendHttpClient<ProjectService>();
        services.AddScoped<ProjectService>();
    }
}
