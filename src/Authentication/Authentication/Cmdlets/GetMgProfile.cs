// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication.Cmdlets
{
    using Microsoft.Graph.PowerShell.Authentication.Extensions;
    using Microsoft.Graph.PowerShell.Authentication.Models;
    using System;
    using System.Linq;
    using System.Management.Automation;
    using static Microsoft.Graph.PowerShell.Authentication.Common.GraphProfile;

    [Cmdlet(VerbsCommon.Get, "MgProfile")]
    [OutputType(typeof(PSGraphServiceProfile))]
    public class GetMgProfile: PSCmdlet
    {
        [Parameter(Mandatory = false)]
        [ValidateNotNullOrEmpty]
        public string[] ModuleName { get; set; }

        [Parameter(Mandatory = false)]
        public SwitchParameter ListAvailable { get; set; }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                bool isModuleNameBound = this.IsBound(nameof(ModuleName));
                bool isListAvailableBound = this.IsBound(nameof(ListAvailable));
                string[] moduleNames = isModuleNameBound ? ModuleName : new string[] { };
                string[] profiles = isModuleNameBound || isListAvailableBound
                    ? GetProfiles(InvokeCommand, isListAvailableBound, moduleNames)
                    : new string[] {
                        // TODO: Get profile from session object.
                    };
                if (profiles.Any((p) => !string.IsNullOrWhiteSpace(p)))
                {
                    WriteObject(profiles.Where((profile) => !string.IsNullOrWhiteSpace(profile))
                        .Select((p) => PSGraphServiceProfile.Create(p)), true);
                }
            }
            catch (Exception ex)
            {
                WriteError(new ErrorRecord(ex, string.Empty, ErrorCategory.CloseError, null));
            }
        }
    }
}
