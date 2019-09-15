using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abp;
using Abp.Extensions;
using Abp.Notifications;
using Abp.Timing;
using UOzturk.Listing.Controllers;
using UOzturk.Listing.SystemCreatedList;

namespace UOzturk.Listing.Web.Host.Controllers
{
    public class HomeController : ListingControllerBase
    {
        private readonly INotificationPublisher _notificationPublisher;
        private readonly ISystemCreatedListAppService _systemCreatedListManager;

        public HomeController(INotificationPublisher notificationPublisher, ISystemCreatedListAppService systemCreatedListManager)
        {
            _notificationPublisher = notificationPublisher;
            _systemCreatedListManager = systemCreatedListManager;
        }

        public IActionResult Index()
        {
            return Redirect("/swagger");
        }

        /// <summary>
        /// This is a demo code to demonstrate sending notification to default tenant admin and host admin uers.
        /// Don't use this code in production !!!
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public async Task<ActionResult> TestNotification(string message = "")
        {
            if (message.IsNullOrEmpty())
            {
                message = "This is a test notification, created at " + Clock.Now;
            }

            var defaultTenantAdmin = new UserIdentifier(1, 2);
            var hostAdmin = new UserIdentifier(null, 1);

            await _notificationPublisher.PublishAsync(
                "App.SimpleMessage",
                new MessageNotificationData(message),
                severity: NotificationSeverity.Info,
                userIds: new[] { defaultTenantAdmin, hostAdmin }
            );

            return Content("Sent notification: " + message);
        }
    }
}
