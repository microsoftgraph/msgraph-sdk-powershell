#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Teams.Client;
using Microsoft.Graph.PowerShell.Teams.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Teams
{
    [GraphRoute("POST", "/teams")]
    [Cmdlet(VerbsCommon.New, "MgTeam", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Teams.Client.Models.Team))]
    public class NewMgTeamCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? Classification { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? FirstChannelName { get; set; }

        [Parameter(Mandatory = false)]
        public string? InternalId { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsArchived { get; set; }

        [Parameter(Mandatory = false)]
        public string? TenantId { get; set; }

        [Parameter(Mandatory = false)]
        public string? WebUrl { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.TeamFunSettings? FunSettings { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.TeamGuestSettings? GuestSettings { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.TeamMemberSettings? MemberSettings { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.TeamMessagingSettings? MessagingSettings { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.TeamSpecialization? Specialization { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.TeamSummary? Summary { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.TeamVisibilityType? Visibility { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Teams.Client.Models.Team();

    if (this.IsParameterBound(nameof(Classification)))
        body.Classification = Classification;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(FirstChannelName)))
        body.FirstChannelName = FirstChannelName;

    if (this.IsParameterBound(nameof(InternalId)))
        body.InternalId = InternalId;

    if (this.IsParameterBound(nameof(IsArchived)))
        body.IsArchived = IsArchived;

    if (this.IsParameterBound(nameof(TenantId)))
        body.TenantId = TenantId;

    if (this.IsParameterBound(nameof(WebUrl)))
        body.WebUrl = WebUrl;

    if (this.IsParameterBound(nameof(FunSettings)))
        body.FunSettings = FunSettings;

    if (this.IsParameterBound(nameof(GuestSettings)))
        body.GuestSettings = GuestSettings;

    if (this.IsParameterBound(nameof(MemberSettings)))
        body.MemberSettings = MemberSettings;

    if (this.IsParameterBound(nameof(MessagingSettings)))
        body.MessagingSettings = MessagingSettings;

    if (this.IsParameterBound(nameof(Specialization)))
        body.Specialization = Specialization;

    if (this.IsParameterBound(nameof(Summary)))
        body.Summary = Summary;

    if (this.IsParameterBound(nameof(Visibility)))
        body.Visibility = Visibility;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Teams.Client.Models.Team? result;
            try
            {
                result = client.Teams.PostAsync(body, requestConfiguration =>
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
