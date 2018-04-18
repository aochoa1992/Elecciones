using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Elecciones.MultiTenancy.Dto;

namespace Elecciones.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
