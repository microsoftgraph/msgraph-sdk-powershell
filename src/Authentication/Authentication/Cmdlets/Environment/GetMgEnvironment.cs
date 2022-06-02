// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Microsoft.Graph.PowerShell.Authentication.Common;
using Microsoft.Graph.PowerShell.Authentication.Models;
using System.Management.Automation;

namespace Microsoft.Graph.PowerShell.Authentication.Cmdlets
{
    /// <summary>
    /// Gets or lists available Microsoft Graph environments to the settings file..
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "MgEnvironment")]
    [OutputType(typeof(GraphEnvironment))]
    public class GetMgEnvironment : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = false, ValueFromPipelineByPropertyName = true, HelpMessage = "The environment name.")]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        protected override void BeginProcessing()
        {
            base.BeginProcessing();
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();

            GraphSettings settings = this.GetContextSettings();
            var environments = settings.ListEnvironments(Name);
            WriteObject(environments, enumerateCollection: true);
        }
    }
}
