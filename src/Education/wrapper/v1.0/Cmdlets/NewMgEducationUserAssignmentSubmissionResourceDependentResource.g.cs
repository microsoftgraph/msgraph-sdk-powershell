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
    [GraphRoute("POST", "/education/users/{educationUser-id}/assignments/{educationAssignment-id}/submissions/{educationSubmission-id}/resources/{educationSubmissionResource-id}/dependentResources")]
    [Cmdlet(VerbsCommon.New, "MgEducationUserAssignmentSubmissionResourceDependentResource", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Education.Client.Models.EducationSubmissionResource))]
    public class NewMgEducationUserAssignmentSubmissionResourceDependentResourceCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string EducationUserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string EducationAssignmentId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string EducationSubmissionId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string EducationSubmissionResourceId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? AssignmentResourceUrl { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Education.Client.Models.EducationResource? Resource { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(EducationSubmissionResourceId, "New"))
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
                result = client.Education.Users[EducationUserId].Assignments[EducationAssignmentId].Submissions[EducationSubmissionId].Resources[EducationSubmissionResourceId].DependentResources.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
