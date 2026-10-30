#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client;
using Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Devices.CorporateManagement
{
    [GraphRoute("POST", "/deviceAppManagement/mobileApps/{mobileApp-id}/updateRelationships")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDeviceAppManagementMobileAppUpdateRelationships", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgDeviceAppManagementMobileAppUpdateRelationshipsCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string MobileAppId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.MobileAppRelationship[]? Relationships { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(MobileAppId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.DeviceAppManagement.MobileApps.Item.UpdateRelationships.UpdateRelationshipsPostRequestBody();

    if (this.IsParameterBound(nameof(Relationships)))
        body.Relationships = Relationships!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.DeviceAppManagement.MobileApps[MobileAppId].UpdateRelationships.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, MobileAppId);
                return;
            }

        }
    }
}
