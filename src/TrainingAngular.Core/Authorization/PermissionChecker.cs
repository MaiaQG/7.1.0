using Abp.Authorization;
using TrainingAngular.Authorization.Roles;
using TrainingAngular.Authorization.Users;

namespace TrainingAngular.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
