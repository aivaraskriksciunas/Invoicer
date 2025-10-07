namespace Invoicer.Front.Services;

public static class Configuration
{
    public static void ConfigureAppServices(this IServiceCollection services)
    {
        // Configure features
        Features.Projects.Configuration.ConfigureServices( services );

        services.AddScoped( client => new HttpClient 
        { 
            BaseAddress = new Uri( "https://localhost:7075" ) 
        } );
    }
}
