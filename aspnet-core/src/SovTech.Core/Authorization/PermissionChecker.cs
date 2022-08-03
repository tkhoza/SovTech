using Abp.Authorization;
using SovTech.Authorization.Roles;
using SovTech.Authorization.Users;

namespace SovTech.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
