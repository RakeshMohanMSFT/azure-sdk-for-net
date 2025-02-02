// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataLakeStore.Models
{
    internal static partial class DataLakeStoreFirewallAllowAzureIPsStateExtensions
    {
        public static string ToSerialString(this DataLakeStoreFirewallAllowAzureIPsState value) => value switch
        {
            DataLakeStoreFirewallAllowAzureIPsState.Enabled => "Enabled",
            DataLakeStoreFirewallAllowAzureIPsState.Disabled => "Disabled",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DataLakeStoreFirewallAllowAzureIPsState value.")
        };

        public static DataLakeStoreFirewallAllowAzureIPsState ToDataLakeStoreFirewallAllowAzureIPsState(this string value)
        {
            if (string.Equals(value, "Enabled", StringComparison.InvariantCultureIgnoreCase)) return DataLakeStoreFirewallAllowAzureIPsState.Enabled;
            if (string.Equals(value, "Disabled", StringComparison.InvariantCultureIgnoreCase)) return DataLakeStoreFirewallAllowAzureIPsState.Disabled;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DataLakeStoreFirewallAllowAzureIPsState value.");
        }
    }
}
