using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Elecciones.Authorization;

namespace Elecciones
{
    [DependsOn(
        typeof(EleccionesCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class EleccionesApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<EleccionesAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(EleccionesApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
