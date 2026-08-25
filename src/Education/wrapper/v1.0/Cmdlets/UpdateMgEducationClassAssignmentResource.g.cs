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
    [GraphRoute("PATCH", "/education/classes/{educationClass-id}/assignments/{educationAssignment-id}/resources/{educationAssignmentResource-id}")]
    [Cmdlet(VerbsData.Update, "MgEducationClassAssignmentResource", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Education.Client.Models.EducationAssignmentResource))]
    public class UpdateMgEducationClassAssignmentResourceCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string EducationClassId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string EducationAssignmentId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string EducationAssignmentResourceId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? DistributeForStudentWork { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Education.Client.Models.EducationResource? Resource { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(EducationAssignmentResourceId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Education.Client.Models.EducationAssignmentResource();

    if (this.IsParameterBound(nameof(DistributeForStudentWork)))
        body.DistributeForStudentWork = DistributeForStudentWork;

    if (this.IsParameterBound(nameof(Resource)))
        body.Resource = Resource;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Education.Client.Models.EducationAssignmentResource? result;
            try
            {
                result = client.Education.Classes[EducationClassId].Assignments[EducationAssignmentId].Resources[EducationAssignmentResourceId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, EducationAssignmentResourceId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Education.Classes[EducationClassId].Assignments[EducationAssignmentId].Resources[EducationAssignmentResourceId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, EducationAssignmentResourceId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
