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
    [GraphRoute("PATCH", "/education/classes/{educationClass-id}/assignmentSettings/gradingCategories/{educationGradingCategory-id}")]
    [Cmdlet(VerbsData.Update, "MgEducationClassAssignmentSettingGradingCategory", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Education.Client.Models.EducationGradingCategory))]
    public class UpdateMgEducationClassAssignmentSettingGradingCategoryCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string EducationClassId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string EducationGradingCategoryId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public int? PercentageWeight { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(EducationGradingCategoryId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Education.Client.Models.EducationGradingCategory();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(PercentageWeight)))
        body.PercentageWeight = PercentageWeight;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Education.Client.Models.EducationGradingCategory? result;
            try
            {
                result = client.Education.Classes[EducationClassId].AssignmentSettings.GradingCategories[EducationGradingCategoryId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, EducationGradingCategoryId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Education.Classes[EducationClassId].AssignmentSettings.GradingCategories[EducationGradingCategoryId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, EducationGradingCategoryId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
