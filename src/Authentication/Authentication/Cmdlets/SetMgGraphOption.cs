// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System.Management.Automation;

namespace Microsoft.Graph.PowerShell.Authentication.Cmdlets
{
    [Cmdlet(VerbsCommon.Set, "MgGraphOption", HelpUri = "")]
    public class SetMgGraphOption : PSCmdlet
    {
        [Parameter]
        public SwitchParameter EnableLoginByWAM { get; set; }

        protected override void BeginProcessing()
        {
            base.BeginProcessing();
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();

            bool currentSetting = GraphSession.Instance.GraphOption.EnableWAMForMSGraph;

            if (EnableLoginByWAM.IsPresent)
            {
                GraphSession.Instance.GraphOption.EnableWAMForMSGraph = EnableLoginByWAM;
                if (GraphSession.Instance.GraphOption.EnableWAMForMSGraph)
                    WriteObject("[Preview] Signin by Web Account Manager (WAM) is enabled.");
                else
                    WriteObject("[Preview] Signin by Web Account Manager (WAM) is disabled.");
            }
            else
            {
                GraphSession.Instance.GraphOption.EnableWAMForMSGraph = !currentSetting;
                if (GraphSession.Instance.GraphOption.EnableWAMForMSGraph)
                    WriteObject("[Preview] Signin by Web Account Manager (WAM) is enabled.");
                else
                    WriteObject("[Preview] Signin by Web Account Manager (WAM) is disabled.");
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