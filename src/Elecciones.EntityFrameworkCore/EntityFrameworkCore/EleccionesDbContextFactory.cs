using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Elecciones.Configuration;
using Elecciones.Web;

namespace Elecciones.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class EleccionesDbContextFactory : IDesignTimeDbContextFactory<EleccionesDbContext>
    {
        public EleccionesDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<EleccionesDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            EleccionesDbContextConfigurer.Configure(builder, configuration.GetConnectionString(EleccionesConsts.ConnectionStringName));

            return new EleccionesDbContext(builder.Options);
        }
    }
}
