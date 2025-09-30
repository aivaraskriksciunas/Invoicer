namespace Invoicer.Front.App;

public static class Configuration
{
    public static void ConfigureAppServices(this IServiceCollection services)
    {
        services.AddScoped( services => new HttpClient
        {
            BaseAddress = new Uri( "https://localhost:7075" )
        } );

        // Configure features
        Projects.Configuration.ConfigureServices( services );
    }
}
