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

    public async Task PutAsync( ProjectModel model )
    {
        await httpClient.PutAsJsonAsync( $"/Projects/{model.Id}", model );
    }

    public async Task<ProjectModel?> GetAsync( Guid id )
    {
        return await httpClient.GetFromJsonAsync<ProjectModel>( $"/Projects/{id}" );
    }
}
