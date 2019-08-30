using System.Threading.Tasks;
using Abp.Application.Services;
using UOzturk.Listing.Sessions.Dto;

namespace UOzturk.Listing.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
