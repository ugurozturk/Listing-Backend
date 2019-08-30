using Abp.AutoMapper;
using UOzturk.Listing.Authentication.External;

namespace UOzturk.Listing.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
