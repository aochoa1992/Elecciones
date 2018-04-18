using System.Threading.Tasks;
using Abp.Application.Services;
using Elecciones.Sessions.Dto;

namespace Elecciones.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
