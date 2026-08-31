#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client;
using Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Devices.CorporateManagement
{
    [GraphRoute("PATCH", "/deviceAppManagement/mobileAppRelationships/{mobileAppRelationship-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceAppManagementMultipleMobileAppRelationship", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.MobileAppRelationship))]
    public class UpdateMgDeviceAppManagementMultipleMobileAppRelationshipCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string MobileAppRelationshipId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? TargetId { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(MobileAppRelationshipId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.MobileAppRelationship();

    if (this.IsParameterBound(nameof(TargetId)))
        body.TargetId = TargetId;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.MobileAppRelationship? result;
            try
            {
                result = client.DeviceAppManagement.MobileAppRelationships[MobileAppRelationshipId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, MobileAppRelationshipId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceAppManagement.MobileAppRelationships[MobileAppRelationshipId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, MobileAppRelationshipId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
