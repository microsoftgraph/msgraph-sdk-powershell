#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement.Client;
using Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement
{
    [GraphRoute("GET", "/admin/serviceAnnouncement/healthOverviews/{serviceHealth-id}")]
    [Cmdlet(VerbsCommon.Get, "MgServiceAnnouncementHealthOverview_Get")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement.Client.Models.ServiceHealth))]
    public class GetMgServiceAnnouncementHealthOverview_GetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ServiceHealthId { get; set; } = string.Empty;



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

            Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement.Client.Models.ServiceHealth? result;
            try
            {
                result = client.Admin.ServiceAnnouncement.HealthOverviews[ServiceHealthId].GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;



        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, ServiceHealthId);
                return;
            }

            WriteObject(result);
        }
    }
}
