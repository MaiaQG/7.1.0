using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace TrainingAngular.Controllers
{
    public abstract class TrainingAngularControllerBase: AbpController
    {
        protected TrainingAngularControllerBase()
        {
            LocalizationSourceName = TrainingAngularConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
