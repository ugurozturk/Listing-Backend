using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using UOzturk.Listing.Configuration;

namespace UOzturk.Listing.Web.Host.Startup
{
    [DependsOn(
       typeof(ListingWebCoreModule))]
    public class ListingWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ListingWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ListingWebHostModule).GetAssembly());
        }
    }
}
