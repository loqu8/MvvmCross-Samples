﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XPlatformMenus.Mac.Views
{
    public static class MvxMacExtensionMethods
    {
        public static bool HasRegionAttribute(this Type view)
        {
            var attributes = view
                .GetCustomAttributes(typeof(MvxRegionAttribute), true);
            return attributes.Any();
        }

        public static string GetRegionName(this Type view)
        {
            var attributes = view
                .GetCustomAttributes(typeof(MvxRegionAttribute), true);

            if (!attributes.Any())
                throw new InvalidOperationException("The MvxMacView has no region attribute");

            return ((MvxRegionAttribute)attributes.First()).Name;
        }
    }
}
