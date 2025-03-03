// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------
using System.IO;
using System.Management.Automation;
using System.Text.Json;

namespace Microsoft.Graph.PowerShell.Authentication.Cmdlets
{
    [Cmdlet(VerbsCommon.Set, "MgGraphOption", HelpUri = "")]
    public class SetMgGraphOption : PSCmdlet
    {
        [Parameter]
        public bool EnableLoginByWAM { get; set; }

        private static readonly JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions
        {
            WriteIndented = true
        };

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
            File.WriteAllText(Constants.GraphOptionsFilePath, JsonSerializer.Serialize(GraphSession.Instance.GraphOption, jsonSerializerOptions));
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