﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Disco.Models.BI.Search;
using Disco.Models.Repository;
using Disco.Data.Repository;

namespace Disco.BI.DeviceBI
{
    public static class Searching
    {
        private static List<DeviceSearchResultItem> Search_SelectDeviceSearchResultItem(IQueryable<Device> Query, int? LimitCount = null)
        {
            if (LimitCount.HasValue)
                Query = Query.Take(LimitCount.Value);

            return Query.Select(d => new DeviceSearchResultItem()
            {
                SerialNumber = d.SerialNumber,
                AssetNumber = d.AssetNumber,
                ComputerName = d.ComputerName,
                DeviceModelDescription = d.DeviceModel.Description,
                DeviceProfileDescription = d.DeviceProfile.Description,
                DecommissionedDate = d.DecommissionedDate,
                AssignedUserId = d.AssignedUserId,
                AssignedUserDisplayName = d.AssignedUser.DisplayName,
                JobCount = d.Jobs.Count()
            }).ToList();
        }

        public static List<DeviceSearchResultItem> Search(DiscoDataContext Database, string Term, int? LimitCount = null, bool SearchDetails = false)
        {
            IQueryable<Device> query;

            query = null;

            if (SearchDetails)
            {
                query = Database.Devices.Where(d =>
                    d.AssetNumber.Contains(Term) ||
                    d.ComputerName.Contains(Term) ||
                    d.SerialNumber.Contains(Term) ||
                    d.Location.Contains(Term) ||
                    Term.Contains(d.SerialNumber) ||
                    d.DeviceDetails.Any(dd => dd.Value.Contains(Term))
                    );
            }
            else
            {
                query = Database.Devices.Where(d =>
                    d.AssetNumber.Contains(Term) ||
                    d.ComputerName.Contains(Term) ||
                    d.SerialNumber.Contains(Term) ||
                    d.Location.Contains(Term) ||
                    Term.Contains(d.SerialNumber));
            }
            
            return Search_SelectDeviceSearchResultItem(query, LimitCount);
        }

        public static List<DeviceSearchResultItem> SearchDeviceModel(DiscoDataContext Database, int DeviceModelId, int? LimitCount = null)
        {
            return Search_SelectDeviceSearchResultItem(Database.Devices.Where(d => d.DeviceModelId == DeviceModelId), LimitCount);
        }
        public static List<DeviceSearchResultItem> SearchDeviceProfile(DiscoDataContext Database, int DeviceProfileId, int? LimitCount = null)
        {
            return Search_SelectDeviceSearchResultItem(Database.Devices.Where(d => d.DeviceProfileId == DeviceProfileId), LimitCount);
        }
        public static List<DeviceSearchResultItem> SearchDeviceBatch(DiscoDataContext Database, int DeviceBatchId, int? LimitCount = null)
        {
            return Search_SelectDeviceSearchResultItem(Database.Devices.Where(d => d.DeviceBatchId == DeviceBatchId), LimitCount);
        }

    }
}
