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
    [GraphRoute("POST", "/admin/serviceAnnouncement/healthOverviews/{serviceHealth-id}/issues")]
    [Cmdlet(VerbsCommon.New, "MgAdminServiceAnnouncementHealthOverviewIssue", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement.Client.Models.ServiceHealthIssue))]
    public class NewMgAdminServiceAnnouncementHealthOverviewIssueCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ServiceHealthId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? EndDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? StartDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Title { get; set; }

        [Parameter(Mandatory = false)]
        public string? Feature { get; set; }

        [Parameter(Mandatory = false)]
        public string? FeatureGroup { get; set; }

        [Parameter(Mandatory = false)]
        public string? ImpactDescription { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsResolved { get; set; }

        [Parameter(Mandatory = false)]
        public string? Service { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement.Client.Models.KeyValuePair[]? Details { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement.Client.Models.ServiceHealthClassificationType? Classification { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement.Client.Models.ServiceHealthOrigin? Origin { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement.Client.Models.ServiceHealthIssuePost[]? Posts { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement.Client.Models.ServiceHealthStatus? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ServiceHealthId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement.Client.Models.ServiceHealthIssue();

    if (this.IsParameterBound(nameof(EndDateTime)))
        body.EndDateTime = EndDateTime;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(StartDateTime)))
        body.StartDateTime = StartDateTime;

    if (this.IsParameterBound(nameof(Title)))
        body.Title = Title;

    if (this.IsParameterBound(nameof(Feature)))
        body.Feature = Feature;

    if (this.IsParameterBound(nameof(FeatureGroup)))
        body.FeatureGroup = FeatureGroup;

    if (this.IsParameterBound(nameof(ImpactDescription)))
        body.ImpactDescription = ImpactDescription;

    if (this.IsParameterBound(nameof(IsResolved)))
        body.IsResolved = IsResolved;

    if (this.IsParameterBound(nameof(Service)))
        body.Service = Service;

    if (this.IsParameterBound(nameof(Details)))
        body.Details = Details!.ToList();

    if (this.IsParameterBound(nameof(Classification)))
        body.Classification = Classification;

    if (this.IsParameterBound(nameof(Origin)))
        body.Origin = Origin;

    if (this.IsParameterBound(nameof(Posts)))
        body.Posts = Posts!.ToList();

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.ServiceAnnouncement.Client.Models.ServiceHealthIssue? result;
            try
            {
                result = client.Admin.ServiceAnnouncement.HealthOverviews[ServiceHealthId].Issues.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
