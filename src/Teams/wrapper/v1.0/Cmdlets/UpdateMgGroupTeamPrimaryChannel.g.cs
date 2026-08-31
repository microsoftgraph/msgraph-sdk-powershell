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
    [GraphRoute("PATCH", "/groups/{group-id}/team/primaryChannel")]
    [Cmdlet(VerbsData.Update, "MgGroupTeamPrimaryChannel", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Teams.Client.Models.Channel))]
    public class UpdateMgGroupTeamPrimaryChannelCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? Email { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsArchived { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsFavoriteByDefault { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? OriginalCreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? TenantId { get; set; }

        [Parameter(Mandatory = false)]
        public string? WebUrl { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.ChannelLayoutType? LayoutType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.ChannelMembershipType? MembershipType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.MigrationMode? MigrationMode { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.ChannelSummary? Summary { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(GroupId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Teams.Client.Models.Channel();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(Email)))
        body.Email = Email;

    if (this.IsParameterBound(nameof(IsArchived)))
        body.IsArchived = IsArchived;

    if (this.IsParameterBound(nameof(IsFavoriteByDefault)))
        body.IsFavoriteByDefault = IsFavoriteByDefault;

    if (this.IsParameterBound(nameof(OriginalCreatedDateTime)))
        body.OriginalCreatedDateTime = OriginalCreatedDateTime;

    if (this.IsParameterBound(nameof(TenantId)))
        body.TenantId = TenantId;

    if (this.IsParameterBound(nameof(WebUrl)))
        body.WebUrl = WebUrl;

    if (this.IsParameterBound(nameof(LayoutType)))
        body.LayoutType = LayoutType;

    if (this.IsParameterBound(nameof(MembershipType)))
        body.MembershipType = MembershipType;

    if (this.IsParameterBound(nameof(MigrationMode)))
        body.MigrationMode = MigrationMode;

    if (this.IsParameterBound(nameof(Summary)))
        body.Summary = Summary;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Teams.Client.Models.Channel? result;
            try
            {
                result = client.Groups[GroupId].Team.PrimaryChannel.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, GroupId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Groups[GroupId].Team.PrimaryChannel.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, GroupId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
