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
    [GraphRoute("POST", "/groups/{group-id}/team/schedule/timesOff")]
    [Cmdlet(VerbsCommon.New, "MgGroupTeamScheduleTimeOff", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Teams.Client.Models.TimeOff))]
    public class NewMgGroupTeamScheduleTimeOffCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? IsStagedForDeletion { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.IdentitySet? CreatedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.TimeOffItem? DraftTimeOff { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.TimeOffItem? SharedTimeOff { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(GroupId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Teams.Client.Models.TimeOff();

    if (this.IsParameterBound(nameof(IsStagedForDeletion)))
        body.IsStagedForDeletion = IsStagedForDeletion;

    if (this.IsParameterBound(nameof(UserId)))
        body.UserId = UserId;

    if (this.IsParameterBound(nameof(CreatedBy)))
        body.CreatedBy = CreatedBy;

    if (this.IsParameterBound(nameof(DraftTimeOff)))
        body.DraftTimeOff = DraftTimeOff;

    if (this.IsParameterBound(nameof(SharedTimeOff)))
        body.SharedTimeOff = SharedTimeOff;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Teams.Client.Models.TimeOff? result;
            try
            {
                result = client.Groups[GroupId].Team.Schedule.TimesOff.PostAsync(body, requestConfiguration =>
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
