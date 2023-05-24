// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System.Management.Automation;

namespace Microsoft.Graph.PowerShell.Authentication.Cmdlets
{
    [Cmdlet(VerbsCommon.Set, "MgGraphOption", HelpUri = "")]
    public class SetMgGraphOption : PSCmdlet
    {
        protected override void BeginProcessing()
        {
            base.BeginProcessing();
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            GraphSession.Instance.GraphOption.EnableWAMForMSGraph = !GraphSession.Instance.GraphOption.EnableWAMForMSGraph;
            if (GraphSession.Instance.GraphOption.EnableWAMForMSGraph == true)
            {
                WriteObject("WAM Signin currently enabled");
            }
            else
            {
                WriteObject("WAM Signin disabled");
            }
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