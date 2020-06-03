// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication.Cmdlets
{
    using Microsoft.Graph.PowerShell.Authentication.Extensions;
    using System;
    using System.Linq;
    using System.Management.Automation;
    using static Microsoft.Graph.PowerShell.Authentication.Common.GraphProfile;

    /// <summary>
    /// Select the current Microsoft Graph profile.
    /// </summary>
    [Cmdlet(VerbsCommon.Select, "MgProfile", SupportsShouldProcess = true)]
    [OutputType(typeof(bool))]
    public class SelectMgProfile: PSCmdlet
    {
        [Parameter(Mandatory = true)]
        [Alias("ProfileName")]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        [Parameter]
        public SwitchParameter PassThru { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                if (this.IsParameterBound(c => c.Name))
                {
                    PSModuleInfo[] modules = GetModules(InvokeCommand).Where(m => GetProfiles(m).Contains(Name)).ToArray();
                    string moduleList = string.Join(", ", modules.Select(m => m.Name));
                    if (ShouldProcess($"Modules {moduleList}", $"Load modules with profile {Name}"))
                    {
                        GraphSession.Instance.SelectedProfile = Name;
                        ReloadModules(InvokeCommand, modules);
                        if (PassThru.IsPresent && PassThru.ToBool())
                        {
                            WriteObject(true);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                WriteError(new ErrorRecord(ex, string.Empty, ErrorCategory.CloseError, null));
            }
        }
    }
}
