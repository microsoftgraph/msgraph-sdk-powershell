// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Microsoft.Graph.PowerShell.Authentication.Core.Interfaces;
using Microsoft.Graph.PowerShell.Authentication.Models;
using System.Management.Automation;

namespace Microsoft.Graph.PowerShell.Authentication.Cmdlets.RequestContext
{
    [Cmdlet(VerbsCommon.Get, "MgRequestContext", SupportsShouldProcess = true)]
    [OutputType(typeof(IRequestContext))]
    public class GetMgRequestContext : PSCmdlet
    {
        protected override void BeginProcessing()
        {
            base.BeginProcessing();
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            WriteObject(GraphSession.Instance.RequestContext);
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
