using Api.Domain.Interfaces.Services.Directory;
using Api.Domain.Interfaces.Services.GeometricForm;
using Api.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Api.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IDirectoryService, DirectoryService>();
            serviceCollection.AddTransient<IGeometricFormService, GeometricFormService>();
        }
    }
}
