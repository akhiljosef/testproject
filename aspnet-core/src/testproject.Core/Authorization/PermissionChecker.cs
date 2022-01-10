using Abp.Authorization;
using testproject.Authorization.Roles;
using testproject.Authorization.Users;

namespace testproject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
