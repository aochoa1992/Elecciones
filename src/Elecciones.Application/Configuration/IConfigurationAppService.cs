using System.Threading.Tasks;
using Elecciones.Configuration.Dto;

namespace Elecciones.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
