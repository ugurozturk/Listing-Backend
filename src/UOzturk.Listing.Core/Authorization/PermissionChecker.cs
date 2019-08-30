using Abp.Authorization;
using UOzturk.Listing.Authorization.Roles;
using UOzturk.Listing.Authorization.Users;

namespace UOzturk.Listing.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
