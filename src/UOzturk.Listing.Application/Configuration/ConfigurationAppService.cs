using Abp.Authorization;
using Abp.Runtime.Session;
using System.Threading.Tasks;
using UOzturk.Listing.Configuration.Dto;

namespace UOzturk.Listing.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ListingAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}