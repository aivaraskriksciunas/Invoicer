using Invoicer.Front.Features.Projects.Models;
using System.Net.Http.Json;

namespace Invoicer.Front.Features.Projects.Services;

public class ProjectService (HttpClient httpClient)
{
    public async Task<ProjectModel[]> ListAsync()
    {
        return await httpClient.GetFromJsonAsync<ProjectModel[]>( "/Projects" ) ?? [];
    }

    public async Task PostAsync( ProjectModel model )
    {
        await httpClient.PostAsJsonAsync( "/Projects", model );
    }

    public async Task<ProjectModel?> GetAsync( int id )
    {
        return await httpClient.GetFromJsonAsync<ProjectModel>( $"/Projects/{id}" );
    }
}
