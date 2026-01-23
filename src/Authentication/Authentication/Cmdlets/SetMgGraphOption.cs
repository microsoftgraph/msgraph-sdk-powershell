// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Newtonsoft.Json;
using System.IO;
using System.Management.Automation;

namespace Microsoft.Graph.PowerShell.Authentication.Cmdlets
{
    [Cmdlet(VerbsCommon.Set, "MgGraphOption", HelpUri = "")]
    public class SetMgGraphOption : PSCmdlet
    {
        [Parameter]
        public bool? DisableLoginByWAM { get; set; }

        protected override void BeginProcessing()
        {
            base.BeginProcessing();
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            if (this.IsParameterBound(nameof(DisableLoginByWAM)))
            {
                GraphSession.Instance.GraphOption.DisableWAMForMSGraph = DisableLoginByWAM;
                WriteDebug($"Requested to {(DisableLoginByWAM == true ? "disable" : "enable")} sign in by Web Account Manager (WAM).");
                if (DisableLoginByWAM == true)
                {
                    WriteDebug("Note: Sign in by Web Account Manager (WAM) can only be disabled when using a custom ClientId (not the default PowerShell SDK ClientId). If using the default ClientId, WAM will remain enabled.");
                }
            }
            File.WriteAllText(Constants.GraphOptionsFilePath, JsonConvert.SerializeObject(GraphSession.Instance.GraphOption, Formatting.Indented));
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