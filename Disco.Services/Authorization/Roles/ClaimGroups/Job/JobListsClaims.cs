﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disco.Services.Authorization.Roles.ClaimGroups.Job
{
    [ClaimDetails("Lists", "Permissions related to Job Lists")]
    public class JobListsClaims : BaseRoleClaimGroup
    {
        [ClaimDetails("Awaiting Technician Action List", "Can show list")]
        public bool AwaitingTechnicianAction { get; set; }
        [ClaimDetails("Long Running Jobs List", "Can show list")]
        public bool LongRunningJobs { get; set; }

        [ClaimDetails("All Open List", "Can show list")]
        public bool AllOpen { get; set; }
        [ClaimDetails("Devices Ready For Return List", "Can show list")]
        public bool DevicesReadyForReturn { get; set; }
        [ClaimDetails("Devices Awaiting Repair List", "Can show list")]
        public bool DevicesAwaitingRepair { get; set; }
        
        [ClaimDetails("Awaiting Finance List", "Can show list")]
        public bool AwaitingFinance { get; set; }

        [ClaimDetails("Awaiting Finance Charge List", "Can show list (NOTE: Requires Awaiting Finance List)")]
        public bool AwaitingFinanceCharge { get; set; }
        [ClaimDetails("Awaiting Finance Payment List", "Can show list (NOTE: Requires Awaiting Finance List)")]
        public bool AwaitingFinancePayment { get; set; }
        [ClaimDetails("Awaiting Finance Insurance Processing List", "Can show list (NOTE: Requires Awaiting Finance List)")]
        public bool AwaitingFinanceInsuranceProcessing { get; set; }
        [ClaimDetails("Awaiting Finance Agreement Breach List", "Can show list (NOTE: Requires Awaiting Finance List)")]
        public bool AwaitingFinanceAgreementBreach { get; set; }
        
        [ClaimDetails("Awaiting User Action List", "Can show list")]
        public bool AwaitingUserAction { get; set; }
        [ClaimDetails("Recently Closed List", "Can show list")]
        public bool RecentlyClosed { get; set; }
        [ClaimDetails("Locations List", "Can show list")]
        public bool Locations { get; set; }
    }
}
