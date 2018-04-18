using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Elecciones.Roles.Dto;
using Elecciones.Users.Dto;

namespace Elecciones.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
