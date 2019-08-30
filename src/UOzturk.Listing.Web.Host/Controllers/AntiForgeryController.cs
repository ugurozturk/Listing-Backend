using Microsoft.AspNetCore.Antiforgery;
using UOzturk.Listing.Controllers;

namespace UOzturk.Listing.Web.Host.Controllers
{
    public class AntiForgeryController : ListingControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
