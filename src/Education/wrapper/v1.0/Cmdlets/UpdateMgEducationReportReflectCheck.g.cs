#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Education.Client;
using Microsoft.Graph.PowerShell.Education.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Education
{
    [GraphRoute("PATCH", "/education/reports/reflectCheckInResponses/{reflectCheckInResponse-id}")]
    [Cmdlet(VerbsData.Update, "MgEducationReportReflectCheck", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Education.Client.Models.ReflectCheckInResponse))]
    public class UpdateMgEducationReportReflectCheckCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ReflectCheckInResponseId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? CheckInId { get; set; }

        [Parameter(Mandatory = false)]
        public string? CheckInTitle { get; set; }

        [Parameter(Mandatory = false)]
        public string? ClassId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? CreatorId { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsClosed { get; set; }

        [Parameter(Mandatory = false)]
        public string? ResponderId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? SubmitDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Education.Client.Models.ResponseEmotionType? ResponseEmotion { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Education.Client.Models.ResponseFeedbackType? ResponseFeedback { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ReflectCheckInResponseId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Education.Client.Models.ReflectCheckInResponse();

    if (this.IsParameterBound(nameof(CheckInId)))
        body.CheckInId = CheckInId;

    if (this.IsParameterBound(nameof(CheckInTitle)))
        body.CheckInTitle = CheckInTitle;

    if (this.IsParameterBound(nameof(ClassId)))
        body.ClassId = ClassId;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(CreatorId)))
        body.CreatorId = CreatorId;

    if (this.IsParameterBound(nameof(IsClosed)))
        body.IsClosed = IsClosed;

    if (this.IsParameterBound(nameof(ResponderId)))
        body.ResponderId = ResponderId;

    if (this.IsParameterBound(nameof(SubmitDateTime)))
        body.SubmitDateTime = SubmitDateTime;

    if (this.IsParameterBound(nameof(ResponseEmotion)))
        body.ResponseEmotion = ResponseEmotion;

    if (this.IsParameterBound(nameof(ResponseFeedback)))
        body.ResponseFeedback = ResponseFeedback;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Education.Client.Models.ReflectCheckInResponse? result;
            try
            {
                result = client.Education.Reports.ReflectCheckInResponses[ReflectCheckInResponseId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ReflectCheckInResponseId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Education.Reports.ReflectCheckInResponses[ReflectCheckInResponseId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, ReflectCheckInResponseId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
