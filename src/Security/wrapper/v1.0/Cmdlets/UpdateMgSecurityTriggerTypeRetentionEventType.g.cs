#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Security.Client;
using Microsoft.Graph.PowerShell.Security.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Security
{
    [GraphRoute("PATCH", "/security/triggerTypes/retentionEventTypes/{retentionEventType-id}")]
    [Cmdlet(VerbsData.Update, "MgSecurityTriggerTypeRetentionEventType", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.Security.RetentionEventType))]
    public class UpdateMgSecurityTriggerTypeRetentionEventTypeCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string RetentionEventTypeId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.IdentitySet? CreatedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.IdentitySet? LastModifiedBy { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(RetentionEventTypeId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Security.Client.Models.Security.RetentionEventType();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(CreatedBy)))
        body.CreatedBy = CreatedBy;

    if (this.IsParameterBound(nameof(LastModifiedBy)))
        body.LastModifiedBy = LastModifiedBy;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.Security.RetentionEventType? result;
            try
            {
                result = client.Security.TriggerTypes.RetentionEventTypes[RetentionEventTypeId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, RetentionEventTypeId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Security.TriggerTypes.RetentionEventTypes[RetentionEventTypeId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, RetentionEventTypeId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
