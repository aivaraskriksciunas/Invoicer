using Invoicer.Front.App.Projects.Models;

namespace Invoicer.Front.App.Projects.Services;

public class ProjectService(HttpClient httpClient)
{
    public async Task<ProjectModel[]> ListAsync()
    {
        return await httpClient.GetFromJsonAsync<ProjectModel[]>( "/Projects" ) ?? [];
    }

    public async Task PostAsync(ProjectModel model)
    {
        await httpClient.PostAsJsonAsync( "/Projects", model );
    }
}
