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
    [GraphRoute("POST", "/education/users/{educationUser-id}/rubrics")]
    [Cmdlet(VerbsCommon.New, "MgEducationUserRubric", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Education.Client.Models.EducationRubric))]
    public class NewMgEducationUserRubricCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string EducationUserId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Education.Client.Models.EducationItemBody? Description { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Education.Client.Models.EducationAssignmentGradeType? Grading { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Education.Client.Models.RubricLevel[]? Levels { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Education.Client.Models.RubricQuality[]? Qualities { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(EducationUserId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Education.Client.Models.EducationRubric();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(Grading)))
        body.Grading = Grading;

    if (this.IsParameterBound(nameof(Levels)))
        body.Levels = Levels!.ToList();

    if (this.IsParameterBound(nameof(Qualities)))
        body.Qualities = Qualities!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Education.Client.Models.EducationRubric? result;
            try
            {
                result = client.Education.Users[EducationUserId].Rubrics.PostAsync(body, requestConfiguration =>
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
