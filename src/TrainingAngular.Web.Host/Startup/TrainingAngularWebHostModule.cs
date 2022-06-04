using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using TrainingAngular.Configuration;

namespace TrainingAngular.Web.Host.Startup
{
    [DependsOn(
       typeof(TrainingAngularWebCoreModule))]
    public class TrainingAngularWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public TrainingAngularWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(TrainingAngularWebHostModule).GetAssembly());
        }
    }
}
