#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.NetworkAccess.Client;
using Microsoft.Graph.PowerShell.NetworkAccess.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.NetworkAccess
{
    [GraphRoute("PATCH", "/networkAccess/logs/generativeAIInsights/{generativeAIInsight-transactionId}")]
    [Cmdlet(VerbsData.Update, "MgNetworkAccessLogGenerativeAIInsight", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.GenerativeAIInsight))]
    public class UpdateMgNetworkAccessLogGenerativeAIInsightCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GenerativeAIInsightTransactionId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Content { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? DestinationUrl { get; set; }

        [Parameter(Mandatory = false)]
        public string? EventId { get; set; }

        [Parameter(Mandatory = false)]
        public string? EventType { get; set; }

        [Parameter(Mandatory = false)]
        public string? McpClientName { get; set; }

        [Parameter(Mandatory = false)]
        public string? McpServerName { get; set; }

        [Parameter(Mandatory = false)]
        public string? SessionId { get; set; }

        [Parameter(Mandatory = false)]
        public string? Subactivity { get; set; }

        [Parameter(Mandatory = false)]
        public string? TransactionId { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserPrincipalName { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.ApplicationActivity? Activity { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(GenerativeAIInsightTransactionId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.GenerativeAIInsight();

    if (this.IsParameterBound(nameof(Content)))
        body.Content = Content;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(DestinationUrl)))
        body.DestinationUrl = DestinationUrl;

    if (this.IsParameterBound(nameof(EventId)))
        body.EventId = EventId;

    if (this.IsParameterBound(nameof(EventType)))
        body.EventType = EventType;

    if (this.IsParameterBound(nameof(McpClientName)))
        body.McpClientName = McpClientName;

    if (this.IsParameterBound(nameof(McpServerName)))
        body.McpServerName = McpServerName;

    if (this.IsParameterBound(nameof(SessionId)))
        body.SessionId = SessionId;

    if (this.IsParameterBound(nameof(Subactivity)))
        body.Subactivity = Subactivity;

    if (this.IsParameterBound(nameof(TransactionId)))
        body.TransactionId = TransactionId;

    if (this.IsParameterBound(nameof(UserPrincipalName)))
        body.UserPrincipalName = UserPrincipalName;

    if (this.IsParameterBound(nameof(Activity)))
        body.Activity = Activity;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.GenerativeAIInsight? result;
            try
            {
                result = client.NetworkAccess.Logs.GenerativeAIInsights[GenerativeAIInsightTransactionId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, GenerativeAIInsightTransactionId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.NetworkAccess.Logs.GenerativeAIInsights[GenerativeAIInsightTransactionId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, GenerativeAIInsightTransactionId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
