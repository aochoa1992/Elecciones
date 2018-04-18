using Abp.Authorization;
using Elecciones.Authorization.Roles;
using Elecciones.Authorization.Users;

namespace Elecciones.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
