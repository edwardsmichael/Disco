﻿using Disco.Models.UI.Config.Organisation;
using Disco.Services.Authorization;
using Disco.Services.Plugins.Features.UIExtension;
using Disco.Services.Web;
using System.Web.Mvc;

namespace Disco.Web.Areas.Config.Controllers
{
    public partial class OrganisationController : AuthorizedDatabaseController
    {
        //
        // GET: /Config/Organisation/

        [DiscoAuthorize(Claims.Config.Organisation.Show)]
        public virtual ActionResult Index()
        {
            var viewModel = new Models.Organisation.IndexModel();

            viewModel.OrganisationName = Database.DiscoConfiguration.OrganisationName;
            viewModel.MultiSiteMode = Database.DiscoConfiguration.MultiSiteMode;
            viewModel.OrganisationAddresses = Database.DiscoConfiguration.OrganisationAddresses.Addresses;

            // UI Extensions
            UIExtensions.ExecuteExtensions<ConfigOrganisationIndexModel>(this.ControllerContext, viewModel);

            return View(viewModel);
        }

    }
}
