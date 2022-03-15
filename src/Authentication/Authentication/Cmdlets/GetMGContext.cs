// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication.Cmdlets
{
    using System.Management.Automation;

    [Cmdlet(VerbsCommon.Get, "MgContext", DefaultParameterSetName = Constants.UserParameterSet)]
    [OutputType(typeof(IAuthContext))]
    public class GetMgContext: PSCmdlet
    {
        protected override void BeginProcessing()
        {
            base.BeginProcessing();
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            IAuthContext authConfig = GraphSession.Instance.AuthContext;
            WriteObject(authConfig);
        }

        protected override void EndProcessing()
        {
            base.EndProcessing();
        }

        protected override void StopProcessing()
        {
            base.StopProcessing();
        }
    }
}
