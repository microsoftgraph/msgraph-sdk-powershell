// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Newtonsoft.Json.Linq;
using System.IO;
using System.Management.Automation;

namespace Microsoft.Graph.PowerShell.Authentication.Cmdlets
{
    [Cmdlet(VerbsCommon.Get, "MgGraphOption", HelpUri = "")]
    public class GetMgGraphOption : PSCmdlet
    {
        protected override void BeginProcessing()
        {
            base.BeginProcessing();
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            //File.WriteAllText(Constants.GraphOptionsFilePath, JsonConvert.SerializeObject(GraphSession.Instance.GraphOption, Formatting.Indented));
            WriteObject(new PSObject(JObject.Parse(File.ReadAllText(Constants.GraphOptionsFilePath))));
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