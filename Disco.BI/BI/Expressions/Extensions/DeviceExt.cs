﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Disco.Models.Repository;
using Disco.BI.Extensions;
using Disco.BI.Interop.ActiveDirectory;

namespace Disco.BI.Expressions.Extensions
{
    public static class DeviceExt
    {
        public static object GetActiveDirectoryObjectValue(Device Device, string PropertyName, int Index = 0)
        {
            var adMachineAccount = Device.ActiveDirectoryAccount(PropertyName);
            if (adMachineAccount != null)
                return adMachineAccount.GetPropertyValue(PropertyName, Index);
            else
                return null;
        }

        public static string GetActiveDirectoryStringValue(Device Device, string PropertyName, int Index = 0)
        {
            var objectValue = GetActiveDirectoryObjectValue(Device, PropertyName, Index);
            string stringValue = objectValue as string;
            if (stringValue == null && objectValue != null)
                stringValue = objectValue.ToString();
            return stringValue;
        }

        public static int GetActiveDirectoryIntegerValue(Device Device, string PropertyName, int Index = 0)
        {
            var objectValue = GetActiveDirectoryObjectValue(Device, PropertyName, Index);
            if (objectValue == null)
                return default(int);
            else
            {
                int intValue;
                try
                {
                    intValue = (int)Convert.ChangeType(objectValue, typeof(int));
                }
                catch (Exception)
                {
                    throw;
                }
                return intValue;
            }
        }
    }
}
