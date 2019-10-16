// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------
namespace Microsoft.Graph.PowerShell.Authentication
{
    public static class Constants
    {
        public const string GraphAuthConfigId = "GraphAuthConfigId";
        public const string SDKHeaderValue = "Graph-powershell-{0}-{1}.{2}.{3}";
        internal const string UserParameterSet = "UserParameterSet";
        internal const string AppParameterSet = "AppParameterSet";
        internal static readonly int MaxDeviceCodeTimeOut = 300000; // 5 mins timeout.
    }
}
