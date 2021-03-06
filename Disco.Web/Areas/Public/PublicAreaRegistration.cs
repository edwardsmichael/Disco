﻿using System.Web.Mvc;
using System.Web.Routing;
using Microsoft.AspNet.SignalR;
using Disco.BI.Interop.SignalRHandlers;

namespace Disco.Web.Areas.Public
{
    public class PublicAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Public";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.Routes.MapConnection<UserHeldDeviceNotifications>(
                "Public_UserHeldDevices_Notifications", "Public/UserHeldDevices/Notifications", new ConnectionConfiguration(), SignalRAuthenticationWorkaround.AddMiddleware);
            context.Routes.MapConnection<HeldDeviceNotifications>(
                "Public_HeldDevices_Notifications", "Public/HeldDevices/Notifications", new ConnectionConfiguration(), SignalRAuthenticationWorkaround.AddMiddleware);

            context.MapRoute(
                "Public_Credits",
                "Public/Credits/{id}",
                new { controller = "Public", action = "Credits", id = UrlParameter.Optional },
                new string[] { "Disco.Web.Areas.Public.Controllers" }
            );
            context.MapRoute(
                "Public_Licence",
                "Public/Licence/{id}",
                new { controller = "Public", action = "Licence", id = UrlParameter.Optional },
                new string[] { "Disco.Web.Areas.Public.Controllers" }
            );

            context.MapRoute(
                "Public_default",
                "Public/{controller}/{action}/{id}",
                new { controller = "Public", action = "Index", id = UrlParameter.Optional },
                new string[] { "Disco.Web.Areas.Public.Controllers" }
            );
        }
    }
}
