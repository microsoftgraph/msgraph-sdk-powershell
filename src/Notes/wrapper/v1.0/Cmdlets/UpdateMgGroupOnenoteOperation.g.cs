#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Notes.Client;
using Microsoft.Graph.PowerShell.Notes.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Notes
{
    [GraphRoute("PATCH", "/groups/{group-id}/onenote/operations/{onenoteOperation-id}")]
    [Cmdlet(VerbsData.Update, "MgGroupOnenoteOperation", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Notes.Client.Models.OnenoteOperation))]
    public class UpdateMgGroupOnenoteOperationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string OnenoteOperationId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastActionDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? PercentComplete { get; set; }

        [Parameter(Mandatory = false)]
        public string? ResourceId { get; set; }

        [Parameter(Mandatory = false)]
        public string? ResourceLocation { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Notes.Client.Models.OperationStatus? Status { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Notes.Client.Models.OnenoteOperationError? Error { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(OnenoteOperationId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Notes.Client.Models.OnenoteOperation();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(LastActionDateTime)))
        body.LastActionDateTime = LastActionDateTime;

    if (this.IsParameterBound(nameof(PercentComplete)))
        body.PercentComplete = PercentComplete;

    if (this.IsParameterBound(nameof(ResourceId)))
        body.ResourceId = ResourceId;

    if (this.IsParameterBound(nameof(ResourceLocation)))
        body.ResourceLocation = ResourceLocation;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;

    if (this.IsParameterBound(nameof(Error)))
        body.Error = Error;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Notes.Client.Models.OnenoteOperation? result;
            try
            {
                result = client.Groups[GroupId].Onenote.Operations[OnenoteOperationId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, OnenoteOperationId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Groups[GroupId].Onenote.Operations[OnenoteOperationId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, OnenoteOperationId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
