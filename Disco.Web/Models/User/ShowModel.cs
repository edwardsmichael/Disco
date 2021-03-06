﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Disco.BI;
using Disco.BI.Extensions;
using Disco.Models.Interop.ActiveDirectory;
using Disco.Models.UI.User;
using Disco.Web.Extensions;
using Disco.Models.Authorization;
using Disco.Web.Models.Shared;

namespace Disco.Web.Models.User
{
    public class ShowModel : UserShowModel
    {
        public Disco.Models.Repository.User User { get; set; }
        public Disco.Models.BI.Job.JobTableModel Jobs { get; set; }
        public List<Disco.Models.Repository.DocumentTemplate> DocumentTemplates { get; set; }
        public IAuthorizationToken AuthorizationToken { get; set; }
        public IClaimNavigatorItem ClaimNavigator { get; set; }

        public FancyTreeNode[] ClaimNavigatorFancyTreeNodes
        {
            get
            {
                var rootNode = FancyTreeNode.FromClaimNavigatorItem(this.ClaimNavigator, true);
                rootNode.expanded = true;

                return new FancyTreeNode[] {
                    rootNode
                };
            }
        }

        public List<SelectListItem> DocumentTemplatesSelectListItems
        {
            get
            {
                var list = new List<SelectListItem>();
                list.Add(new SelectListItem() { Selected = true, Value = string.Empty, Text = "Select a Document to Generate" });
                list.AddRange(this.DocumentTemplates.ToSelectListItems());
                return list;
            }
        }

        public string PrimaryDeviceSerialNumber
        {
            get
            {
                var assignedDevice = User.DeviceUserAssignments.Where(d => !d.UnassignedDate.HasValue).FirstOrDefault();
                if (assignedDevice == null)
                {
                    return null;
                }
                else
                {
                    return assignedDevice.DeviceSerialNumber;
                }
            }
        }
    }
}