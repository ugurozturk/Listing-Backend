using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using UOzturk.Listing.Authorization;

namespace UOzturk.Listing
{
    [DependsOn(
        typeof(ListingCoreModule),
        typeof(AbpAutoMapperModule))]
    public class ListingApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ListingAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ListingApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}