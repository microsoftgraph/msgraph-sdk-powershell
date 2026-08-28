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
    [GraphRoute("POST", "/education/me/assignments/{educationAssignment-id}/submissions/{educationSubmission-id}/submittedResources")]
    [Cmdlet(VerbsCommon.New, "MgEducationMeAssignmentSubmissionSubmittedResource", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Education.Client.Models.EducationSubmissionResource))]
    public class NewMgEducationMeAssignmentSubmissionSubmittedResourceCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string EducationAssignmentId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string EducationSubmissionId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? AssignmentResourceUrl { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Education.Client.Models.EducationResource? Resource { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(EducationSubmissionId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Education.Client.Models.EducationSubmissionResource();

    if (this.IsParameterBound(nameof(AssignmentResourceUrl)))
        body.AssignmentResourceUrl = AssignmentResourceUrl;

    if (this.IsParameterBound(nameof(Resource)))
        body.Resource = Resource;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Education.Client.Models.EducationSubmissionResource? result;
            try
            {
                result = client.Education.Me.Assignments[EducationAssignmentId].Submissions[EducationSubmissionId].SubmittedResources.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
