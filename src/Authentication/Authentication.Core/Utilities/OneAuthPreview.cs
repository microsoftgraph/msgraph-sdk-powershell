#if ONEAUTH_PREVIEW
using System;

namespace Microsoft.Graph.PowerShell.Authentication.Core.Utilities
{
    internal static class OneAuthPreview
    {
        internal static bool UseDPoP => IsEnabled(
            "Azure.Identity.Broker.EnableOneAuthDPoP", "AZURE_IDENTITY_BROKER_ENABLE_ONEAUTH_DPOP");

        internal static bool IsActive => UseDPoP || IsEnabled(
            "Azure.Identity.Broker.EnableOneAuthRuntime", "AZURE_IDENTITY_BROKER_ENABLE_ONEAUTH");

        private static bool IsEnabled(string switchName, string environmentVariable)
        {
            return AppContext.TryGetSwitch(switchName, out bool enabled)
                ? enabled
                : bool.TryParse(Environment.GetEnvironmentVariable(environmentVariable), out enabled) && enabled;
        }
    }
}
#endif
