using System.Threading.Tasks;
using Abp.Application.Services;
using Elecciones.Authorization.Accounts.Dto;

namespace Elecciones.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
