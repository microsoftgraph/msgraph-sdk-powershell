#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Sites.Client;
using Microsoft.Graph.PowerShell.Sites.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Sites
{
    [GraphRoute("POST", "/groups/{group-id}/sites/{site-id}/informationProtection/threatAssessmentRequests/{threatAssessmentRequest-id}/results")]
    [Cmdlet(VerbsCommon.New, "MgGroupSiteInformationProtectionThreatAssessmentRequestResult", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Sites.Client.Models.ThreatAssessmentResult))]
    public class NewMgGroupSiteInformationProtectionThreatAssessmentRequestResultCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SiteId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string ThreatAssessmentRequestId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Message { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.ThreatAssessmentResultType? ResultType { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ThreatAssessmentRequestId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Sites.Client.Models.ThreatAssessmentResult();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(Message)))
        body.Message = Message;

    if (this.IsParameterBound(nameof(ResultType)))
        body.ResultType = ResultType;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Sites.Client.Models.ThreatAssessmentResult? result;
            try
            {
                result = client.Groups[GroupId].Sites[SiteId].InformationProtection.ThreatAssessmentRequests[ThreatAssessmentRequestId].Results.PostAsync(body, requestConfiguration =>
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
