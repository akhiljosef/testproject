using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace testproject.Controllers
{
    public abstract class testprojectControllerBase: AbpController
    {
        protected testprojectControllerBase()
        {
            LocalizationSourceName = testprojectConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
