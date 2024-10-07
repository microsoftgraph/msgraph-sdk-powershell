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
        public bool EnableLoginByWAM { get; set; }
        
        [Parameter]
        public bool EnableATPoP { get; set; }

        protected override void BeginProcessing()
        {
            base.BeginProcessing();
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            if (this.IsParameterBound(nameof(EnableLoginByWAM)))
            {
                GraphSession.Instance.GraphOption.EnableWAMForMSGraph = EnableLoginByWAM;
                WriteDebug($"Signin by Web Account Manager (WAM) is {(EnableLoginByWAM ? "enabled" : "disabled")}.");
            }
            if (this.IsParameterBound(nameof(EnableATPoP)))
            {
                GraphSession.Instance.GraphOption.EnableATPoPForMSGraph = EnableATPoP;
                WriteDebug($"Access Token Proof of Posession (AT-PoP) is {(EnableATPoP ? "enabled" : "disabled")}.");
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