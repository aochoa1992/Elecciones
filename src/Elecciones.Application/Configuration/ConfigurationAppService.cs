using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Elecciones.Configuration.Dto;

namespace Elecciones.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : EleccionesAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
