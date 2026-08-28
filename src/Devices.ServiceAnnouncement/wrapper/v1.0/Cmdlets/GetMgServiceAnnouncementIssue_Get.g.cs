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
    [GraphRoute("GET", "/admin/serviceAnnouncement/issues/{serviceHealthIssue-id}")]
    [Cmdlet(VerbsCommon.Get, "MgServiceAnnouncementIssue_Get")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement.Client.Models.ServiceHealthIssue))]
    public class GetMgServiceAnnouncementIssue_GetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ServiceHealthIssueId { get; set; } = string.Empty;



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

            Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement.Client.Models.ServiceHealthIssue? result;
            try
            {
                result = client.Admin.ServiceAnnouncement.Issues[ServiceHealthIssueId].GetAsync(requestConfiguration =>
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
                ThrowGraphRequestFailed(ex, ServiceHealthIssueId);
                return;
            }

            WriteObject(result);
        }
    }
}
