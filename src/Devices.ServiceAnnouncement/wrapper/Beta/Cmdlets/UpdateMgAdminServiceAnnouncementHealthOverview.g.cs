#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement.Client;
using Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement
{
    [GraphRoute("PATCH", "/admin/serviceAnnouncement/healthOverviews/{serviceHealth-id}")]
    [Cmdlet(VerbsData.Update, "MgAdminServiceAnnouncementHealthOverview", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement.Client.Models.ServiceHealth))]
    public class UpdateMgAdminServiceAnnouncementHealthOverviewCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ServiceHealthId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Service { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement.Client.Models.ServiceHealthStatus? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ServiceHealthId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement.Client.Models.ServiceHealth();

    if (this.IsParameterBound(nameof(Service)))
        body.Service = Service;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement.Client.Models.ServiceHealth? result;
            try
            {
                result = client.Admin.ServiceAnnouncement.HealthOverviews[ServiceHealthId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ServiceHealthId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Admin.ServiceAnnouncement.HealthOverviews[ServiceHealthId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, ServiceHealthId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
