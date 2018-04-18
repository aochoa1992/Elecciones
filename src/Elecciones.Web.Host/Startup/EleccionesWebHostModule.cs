using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Elecciones.Configuration;

namespace Elecciones.Web.Host.Startup
{
    [DependsOn(
       typeof(EleccionesWebCoreModule))]
    public class EleccionesWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public EleccionesWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(EleccionesWebHostModule).GetAssembly());
        }
    }
}
