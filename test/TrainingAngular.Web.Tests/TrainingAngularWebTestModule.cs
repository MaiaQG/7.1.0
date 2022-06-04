using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TrainingAngular.EntityFrameworkCore;
using TrainingAngular.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace TrainingAngular.Web.Tests
{
    [DependsOn(
        typeof(TrainingAngularWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class TrainingAngularWebTestModule : AbpModule
    {
        public TrainingAngularWebTestModule(TrainingAngularEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TrainingAngularWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(TrainingAngularWebMvcModule).Assembly);
        }
    }
}