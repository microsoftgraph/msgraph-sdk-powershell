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
    [GraphRoute("POST", "/deviceManagement/importedDeviceIdentities/importDeviceIdentityList")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDeviceManagementImportedDeviceIdentityImportDeviceIdentityList", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.DeviceManagement.ImportedDeviceIdentities.ImportDeviceIdentityList.ImportDeviceIdentityListPostResponse))]
    public class InvokeMgDeviceManagementImportedDeviceIdentityImportDeviceIdentityListCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public bool? OverwriteImportedDeviceIdentities { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.ImportedDeviceIdentity[]? ImportedDeviceIdentities { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.DeviceManagement.ImportedDeviceIdentities.ImportDeviceIdentityList.ImportDeviceIdentityListPostRequestBody();

    if (this.IsParameterBound(nameof(OverwriteImportedDeviceIdentities)))
        body.OverwriteImportedDeviceIdentities = OverwriteImportedDeviceIdentities;
    if (this.IsParameterBound(nameof(ImportedDeviceIdentities)))
        body.ImportedDeviceIdentities = ImportedDeviceIdentities!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.DeviceManagement.ImportedDeviceIdentities.ImportDeviceIdentityList.ImportDeviceIdentityListPostResponse? result;
            try
            {
                result = client.DeviceManagement.ImportedDeviceIdentities.ImportDeviceIdentityList.PostAsImportDeviceIdentityListPostResponseAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }

            WriteObject(result);
        }
    }
}
