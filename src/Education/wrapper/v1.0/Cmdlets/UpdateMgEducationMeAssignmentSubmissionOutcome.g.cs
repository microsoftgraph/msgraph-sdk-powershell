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
    [GraphRoute("PATCH", "/education/me/assignments/{educationAssignment-id}/submissions/{educationSubmission-id}/outcomes/{educationOutcome-id}")]
    [Cmdlet(VerbsData.Update, "MgEducationMeAssignmentSubmissionOutcome", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Education.Client.Models.EducationOutcome))]
    public class UpdateMgEducationMeAssignmentSubmissionOutcomeCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string EducationAssignmentId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string EducationSubmissionId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string EducationOutcomeId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Education.Client.Models.IdentitySet? LastModifiedBy { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(EducationOutcomeId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Education.Client.Models.EducationOutcome();

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(LastModifiedBy)))
        body.LastModifiedBy = LastModifiedBy;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Education.Client.Models.EducationOutcome? result;
            try
            {
                result = client.Education.Me.Assignments[EducationAssignmentId].Submissions[EducationSubmissionId].Outcomes[EducationOutcomeId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, EducationOutcomeId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Education.Me.Assignments[EducationAssignmentId].Submissions[EducationSubmissionId].Outcomes[EducationOutcomeId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, EducationOutcomeId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
