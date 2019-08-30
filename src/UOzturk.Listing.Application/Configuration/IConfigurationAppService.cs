using System.Threading.Tasks;
using UOzturk.Listing.Configuration.Dto;

namespace UOzturk.Listing.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
