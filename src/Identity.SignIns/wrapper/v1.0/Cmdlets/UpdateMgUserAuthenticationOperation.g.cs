#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.SignIns
{
    [GraphRoute("PATCH", "/users/{user-id}/authentication/operations/{longRunningOperation-id}")]
    [Cmdlet(VerbsData.Update, "MgUserAuthenticationOperation", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.LongRunningOperation))]
    public class UpdateMgUserAuthenticationOperationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string LongRunningOperationId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastActionDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? ResourceLocation { get; set; }

        [Parameter(Mandatory = false)]
        public string? StatusDetail { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.LongRunningOperationStatus? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(LongRunningOperationId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.LongRunningOperation();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(LastActionDateTime)))
        body.LastActionDateTime = LastActionDateTime;

    if (this.IsParameterBound(nameof(ResourceLocation)))
        body.ResourceLocation = ResourceLocation;

    if (this.IsParameterBound(nameof(StatusDetail)))
        body.StatusDetail = StatusDetail;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.LongRunningOperation? result;
            try
            {
                result = client.Users[UserId].Authentication.Operations[LongRunningOperationId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, LongRunningOperationId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Users[UserId].Authentication.Operations[LongRunningOperationId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, LongRunningOperationId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
