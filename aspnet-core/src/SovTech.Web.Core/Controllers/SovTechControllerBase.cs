using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace SovTech.Controllers
{
    public abstract class SovTechControllerBase: AbpController
    {
        protected SovTechControllerBase()
        {
            LocalizationSourceName = SovTechConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
