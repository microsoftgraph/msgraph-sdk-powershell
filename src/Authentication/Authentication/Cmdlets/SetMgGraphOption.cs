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

        protected override void BeginProcessing()
        {
            base.BeginProcessing();
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            if (EnableLoginByWAM)
            {
                GraphSession.Instance.GraphOption.EnableWAMForMSGraph = EnableLoginByWAM;
                WriteObject("[Preview] Signin by Web Account Manager (WAM) is enabled.");
            }
            else
            {
                GraphSession.Instance.GraphOption.EnableWAMForMSGraph = false;
                WriteObject("[Preview] Signin by Web Account Manager (WAM) is disabled.");
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