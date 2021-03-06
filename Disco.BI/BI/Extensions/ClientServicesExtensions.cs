﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Disco.Models.ClientServices;
using System.Web;
using Disco.Data.Repository;
using Disco.Models.Repository;
using Disco.Services.Users;
using Disco.Services.Authorization;

namespace Disco.BI.Extensions
{
    public static class ClientServicesExtensions
    {
        public static EnrolResponse BuildResponse(this Enrol request)
        {
            if (HttpContext.Current == null)
                throw new PlatformNotSupportedException("This function can only be accessed from within ASP.NET");

            string username = null;
            if (HttpContext.Current.Request.IsAuthenticated)
                username = HttpContext.Current.User.Identity.Name;

            using (DiscoDataContext database = new DiscoDataContext())
            {
                EnrolResponse response = DeviceBI.DeviceEnrol.Enrol(database, username, request);
                database.SaveChanges();
                return response;
            }
        }

        public static WhoAmIResponse BuildResponse(this WhoAmI request)
        {
            if (HttpContext.Current == null)
                throw new PlatformNotSupportedException("This function can only be accessed from within ASP.NET");

            string username = null;
            if (HttpContext.Current.Request.IsAuthenticated)
                username = HttpContext.Current.User.Identity.Name;

            if (username == null)
                throw new InvalidOperationException("Unauthenticated Http Context");

            using (DiscoDataContext database = new DiscoDataContext())
            {
                AuthorizationToken token = UserService.GetAuthorization(username, database, true);

                WhoAmIResponse response = new WhoAmIResponse()
                {
                    Username = token.User.Id,
                    DisplayName = token.User.DisplayName,
                    Type = token.Has(Claims.ComputerAccount) ? "Computer Account" : "User Account"
                };
                return response;
            }
        }

        public static MacEnrolResponse BuildResponse(this MacEnrol request)
        {
            if (HttpContext.Current == null)
                throw new PlatformNotSupportedException("This function can only be accessed from within ASP.NET");

            using (DiscoDataContext database = new DiscoDataContext())
            {
                MacEnrolResponse response = DeviceBI.DeviceEnrol.MacEnrol(database, request, false);
                database.SaveChanges();
                return response;
            }
        }

    }
}
