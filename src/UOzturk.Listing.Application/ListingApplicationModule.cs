using Abp.AutoMapper;
using Abp.Dependency;
using Abp.Modules;
using Abp.Reflection.Extensions;
using UOzturk.Listing.Authorization;
using UOzturk.Listing.Facade;
using UOzturk.Listing.Facade.IFacade;

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
            IocManager.Register<ISystemCreatedListFacade, SystemCreatedListFacade>(DependencyLifeStyle.Transient);
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