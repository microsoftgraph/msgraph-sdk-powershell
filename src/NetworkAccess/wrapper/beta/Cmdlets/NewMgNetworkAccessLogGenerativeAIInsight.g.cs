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
    [GraphRoute("POST", "/networkAccess/logs/generativeAIInsights")]
    [Cmdlet(VerbsCommon.New, "MgNetworkAccessLogGenerativeAIInsight", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.GenerativeAIInsight))]
    public class NewMgNetworkAccessLogGenerativeAIInsightCommand : GraphClientCmdlet
    {


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
            if (!ShouldProcess(null, "New"))
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
                result = client.NetworkAccess.Logs.GenerativeAIInsights.PostAsync(body, requestConfiguration =>
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
