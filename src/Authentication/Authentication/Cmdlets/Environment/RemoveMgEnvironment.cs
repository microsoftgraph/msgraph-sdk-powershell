// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using Microsoft.Graph.PowerShell.Authentication.Common;
using Microsoft.Graph.PowerShell.Authentication.Helpers;
using Microsoft.Graph.PowerShell.Authentication.Models;
using System;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.Graph.PowerShell.Authentication.Cmdlets
{
    /// <summary>
    /// Removes Microsoft Graph environment to the settings file..
    /// </summary>
    [Cmdlet(VerbsCommon.Remove, "MgEnvironment", SupportsShouldProcess = true, HelpUri = "https://learn.microsoft.com/powershell/microsoftgraph/authentication-commands#using-get-mgenvironment")]
    [OutputType(typeof(GraphEnvironment))]
    public class RemoveMgEnvironment : PSCmdlet
    {
        [Parameter(Position = 0, Mandatory = true, ValueFromPipelineByPropertyName = true, HelpMessage = "The environment name.")]
        public string Name { get; set; }

        protected override void BeginProcessing()
        {
            base.BeginProcessing();
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();

            if (ShouldProcess("removing environment", Name))
            {
                if (GraphEnvironment.BuiltInEnvironments.Keys.Any((k) => string.Equals(k, Name, StringComparison.CurrentCultureIgnoreCase)))
                {
                    throw new InvalidOperationException(
                        ErrorConstants.Message.CannotModifyBuiltInEnvironment.FormatCurrentCulture("remove", Name));
                }

                GraphSettings settings = this.GetContextSettings();
                WriteObject(settings.RemoveEnvironment(Name));
            }
        }
    }
}
