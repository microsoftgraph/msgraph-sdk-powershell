#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client;
using Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement.Enrollment
{
    [GraphRoute("POST", "/deviceManagement/importedWindowsAutopilotDeviceIdentities/import")]
    [Cmdlet(VerbsData.Import, "MgDeviceManagementImportedWindowsAutopilotDeviceIdentity", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.DeviceManagement.ImportedWindowsAutopilotDeviceIdentities.Import.ImportPostResponse))]
    public class ImportMgDeviceManagementImportedWindowsAutopilotDeviceIdentityCommand : GraphClientCmdlet
    {



        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.ImportedWindowsAutopilotDeviceIdentity[]? ImportedWindowsAutopilotDeviceIdentities { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Import"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.DeviceManagement.ImportedWindowsAutopilotDeviceIdentities.Import.ImportPostRequestBody();

    if (this.IsParameterBound(nameof(ImportedWindowsAutopilotDeviceIdentities)))
        body.ImportedWindowsAutopilotDeviceIdentities = ImportedWindowsAutopilotDeviceIdentities!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.DeviceManagement.ImportedWindowsAutopilotDeviceIdentities.Import.ImportPostResponse? result;
            try
            {
                result = client.DeviceManagement.ImportedWindowsAutopilotDeviceIdentities.Import.PostAsImportPostResponseAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }

            WriteObject(result);
        }
    }
}
