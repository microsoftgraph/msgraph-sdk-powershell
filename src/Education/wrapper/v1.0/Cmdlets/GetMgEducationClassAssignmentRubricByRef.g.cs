#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Education.Client;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Education
{
    [GraphRoute("GET", "/education/classes/{educationClass-id}/assignments/{educationAssignment-id}/rubric/$ref")]
    [Cmdlet(VerbsCommon.Get, "MgEducationClassAssignmentRubricByRef")]
    [OutputType(typeof(string))]
    public class GetMgEducationClassAssignmentRubricByRefCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string EducationClassId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string EducationAssignmentId { get; set; } = string.Empty;







        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            string? result;
            try
            {
                result = client.Education.Classes[EducationClassId].Assignments[EducationAssignmentId].Rubric.Ref.GetAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, EducationAssignmentId);
                return;
            }

            if (result is not null)
                WriteObject(result);
        }
    }
}
