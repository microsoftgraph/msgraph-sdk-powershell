#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.WindowsUpdates.Client;
using Microsoft.Graph.PowerShell.WindowsUpdates.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.WindowsUpdates
{
    [GraphRoute("GET", "/admin/windows/updates/deployments/{deployment-id}/audience/applicableContent/{applicableContent-catalogEntryId}/matchedDevices/{applicableContentDeviceMatch-deviceId}")]
    [Cmdlet(VerbsCommon.Get, "MgWindowsUpdatesDeploymentAudienceApplicableContentMatchedDevice_Get")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.WindowsUpdates.Client.Models.WindowsUpdates.ApplicableContentDeviceMatch))]
    public class GetMgWindowsUpdatesDeploymentAudienceApplicableContentMatchedDevice_GetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeploymentId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ApplicableContentCatalogEntryId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string ApplicableContentDeviceMatchDeviceId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        [Alias("Select")]
        public string[]? Property { get; set; }
        [Parameter(Mandatory = false)]
        [Alias("Expand")]
        public string[]? ExpandProperty { get; set; }



        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.WindowsUpdates.Client.Models.WindowsUpdates.ApplicableContentDeviceMatch? result;
            try
            {
                result = client.Admin.Windows.Updates.Deployments[DeploymentId].Audience.ApplicableContent[ApplicableContentCatalogEntryId].MatchedDevices[ApplicableContentDeviceMatchDeviceId].GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;



        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ApplicableContentDeviceMatchDeviceId);
                return;
            }

            WriteObject(result);
        }
    }
}
