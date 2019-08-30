using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace UOzturk.Listing.Controllers
{
    public abstract class ListingControllerBase: AbpController
    {
        protected ListingControllerBase()
        {
            LocalizationSourceName = ListingConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
