#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Education.Client;
using Microsoft.Graph.PowerShell.Education.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Education
{
    [GraphRoute("GET", "/education/users/{educationUser-id}/assignments/{educationAssignment-id}/submissions/{educationSubmission-id}/submittedResources/{educationSubmissionResource-id}/dependentResources/{educationSubmissionResource-id1}")]
    [Cmdlet(VerbsCommon.Get, "MgEducationUserAssignmentSubmissionSubmittedResourceDependentResource_Get")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Education.Client.Models.EducationSubmissionResource))]
    public class GetMgEducationUserAssignmentSubmissionSubmittedResourceDependentResource_GetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string EducationUserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string EducationAssignmentId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string EducationSubmissionId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string EducationSubmissionResourceId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 4)]
        public string EducationSubmissionResourceId1 { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        [Alias("Select")]
        public string[]? Property { get; set; }
        [Parameter(Mandatory = false)]
        [Alias("Expand")]
        public string[]? ExpandProperty { get; set; }



        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Education.Client.Models.EducationSubmissionResource? result;
            try
            {
                result = client.Education.Users[EducationUserId].Assignments[EducationAssignmentId].Submissions[EducationSubmissionId].SubmittedResources[EducationSubmissionResourceId].DependentResources[EducationSubmissionResourceId1].GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;



        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, EducationSubmissionResourceId1);
                return;
            }

            WriteObject(result);
        }
    }
}
