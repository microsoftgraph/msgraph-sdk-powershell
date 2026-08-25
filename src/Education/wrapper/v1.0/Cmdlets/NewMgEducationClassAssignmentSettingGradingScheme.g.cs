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
    [GraphRoute("POST", "/education/classes/{educationClass-id}/assignmentSettings/gradingSchemes")]
    [Cmdlet(VerbsCommon.New, "MgEducationClassAssignmentSettingGradingScheme", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Education.Client.Models.EducationGradingScheme))]
    public class NewMgEducationClassAssignmentSettingGradingSchemeCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string EducationClassId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public bool? HidePointsDuringGrading { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Education.Client.Models.EducationGradingSchemeGrade[]? Grades { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(EducationClassId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Education.Client.Models.EducationGradingScheme();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(HidePointsDuringGrading)))
        body.HidePointsDuringGrading = HidePointsDuringGrading;

    if (this.IsParameterBound(nameof(Grades)))
        body.Grades = Grades!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Education.Client.Models.EducationGradingScheme? result;
            try
            {
                result = client.Education.Classes[EducationClassId].AssignmentSettings.GradingSchemes.PostAsync(body, requestConfiguration =>
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
