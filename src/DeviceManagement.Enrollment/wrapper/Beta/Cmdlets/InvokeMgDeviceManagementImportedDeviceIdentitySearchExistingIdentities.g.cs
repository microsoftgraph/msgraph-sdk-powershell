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
    [GraphRoute("POST", "/deviceManagement/importedDeviceIdentities/searchExistingIdentities")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDeviceManagementImportedDeviceIdentitySearchExistingIdentities", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.DeviceManagement.ImportedDeviceIdentities.SearchExistingIdentities.SearchExistingIdentitiesPostResponse))]
    public class InvokeMgDeviceManagementImportedDeviceIdentitySearchExistingIdentitiesCommand : GraphClientCmdlet
    {



        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.ImportedDeviceIdentity[]? ImportedDeviceIdentities { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.DeviceManagement.ImportedDeviceIdentities.SearchExistingIdentities.SearchExistingIdentitiesPostRequestBody();

    if (this.IsParameterBound(nameof(ImportedDeviceIdentities)))
        body.ImportedDeviceIdentities = ImportedDeviceIdentities!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.DeviceManagement.ImportedDeviceIdentities.SearchExistingIdentities.SearchExistingIdentitiesPostResponse? result;
            try
            {
                result = client.DeviceManagement.ImportedDeviceIdentities.SearchExistingIdentities.PostAsSearchExistingIdentitiesPostResponseAsync(body, requestConfiguration =>
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
