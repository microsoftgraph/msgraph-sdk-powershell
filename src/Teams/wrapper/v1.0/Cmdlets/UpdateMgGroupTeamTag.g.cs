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
    [GraphRoute("PATCH", "/groups/{group-id}/team/tags/{teamworkTag-id}")]
    [Cmdlet(VerbsData.Update, "MgGroupTeamTag", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Teams.Client.Models.TeamworkTag))]
    public class UpdateMgGroupTeamTagCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string TeamworkTagId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public int? MemberCount { get; set; }

        [Parameter(Mandatory = false)]
        public string? TeamId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.TeamworkTagType? TagType { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(TeamworkTagId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Teams.Client.Models.TeamworkTag();

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(MemberCount)))
        body.MemberCount = MemberCount;

    if (this.IsParameterBound(nameof(TeamId)))
        body.TeamId = TeamId;

    if (this.IsParameterBound(nameof(TagType)))
        body.TagType = TagType;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Teams.Client.Models.TeamworkTag? result;
            try
            {
                result = client.Groups[GroupId].Team.Tags[TeamworkTagId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, TeamworkTagId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Groups[GroupId].Team.Tags[TeamworkTagId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, TeamworkTagId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
