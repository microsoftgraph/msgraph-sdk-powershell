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
    [GraphRoute("PATCH", "/education/classes/{educationClass-id}/assignmentSettings")]
    [Cmdlet(VerbsData.Update, "MgEducationClassAssignmentSetting", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Education.Client.Models.EducationAssignmentSettings))]
    public class UpdateMgEducationClassAssignmentSettingCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string EducationClassId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? SubmissionAnimationDisabled { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(EducationClassId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Education.Client.Models.EducationAssignmentSettings();

    if (this.IsParameterBound(nameof(SubmissionAnimationDisabled)))
        body.SubmissionAnimationDisabled = SubmissionAnimationDisabled;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Education.Client.Models.EducationAssignmentSettings? result;
            try
            {
                result = client.Education.Classes[EducationClassId].AssignmentSettings.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, EducationClassId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Education.Classes[EducationClassId].AssignmentSettings.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, EducationClassId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
