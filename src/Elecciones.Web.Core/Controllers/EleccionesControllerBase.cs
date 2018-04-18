using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Elecciones.Controllers
{
    public abstract class EleccionesControllerBase: AbpController
    {
        protected EleccionesControllerBase()
        {
            LocalizationSourceName = EleccionesConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
