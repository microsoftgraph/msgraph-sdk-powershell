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
    [GraphRoute("PATCH", "/teams/{team-id}/operations/{teamsAsyncOperation-id}")]
    [Cmdlet(VerbsData.Update, "MgTeamOperation", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Teams.Client.Models.TeamsAsyncOperation))]
    public class UpdateMgTeamOperationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string TeamId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string TeamsAsyncOperationId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public int? AttemptsCount { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastActionDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? TargetResourceId { get; set; }

        [Parameter(Mandatory = false)]
        public string? TargetResourceLocation { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.OperationError? Error { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.TeamsAsyncOperationType? OperationType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.TeamsAsyncOperationStatus? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(TeamsAsyncOperationId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Teams.Client.Models.TeamsAsyncOperation();

    if (this.IsParameterBound(nameof(AttemptsCount)))
        body.AttemptsCount = AttemptsCount;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(LastActionDateTime)))
        body.LastActionDateTime = LastActionDateTime;

    if (this.IsParameterBound(nameof(TargetResourceId)))
        body.TargetResourceId = TargetResourceId;

    if (this.IsParameterBound(nameof(TargetResourceLocation)))
        body.TargetResourceLocation = TargetResourceLocation;

    if (this.IsParameterBound(nameof(Error)))
        body.Error = Error;

    if (this.IsParameterBound(nameof(OperationType)))
        body.OperationType = OperationType;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Teams.Client.Models.TeamsAsyncOperation? result;
            try
            {
                result = client.Teams[TeamId].Operations[TeamsAsyncOperationId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, TeamsAsyncOperationId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Teams[TeamId].Operations[TeamsAsyncOperationId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, TeamsAsyncOperationId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
