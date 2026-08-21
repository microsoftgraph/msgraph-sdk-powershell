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
    [GraphRoute("PATCH", "/education/classes/{educationClass-id}/assignmentDefaults")]
    [Cmdlet(VerbsData.Update, "MgEducationClassAssignmentDefault", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Education.Client.Models.EducationAssignmentDefaults))]
    public class UpdateMgEducationClassAssignmentDefaultCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string EducationClassId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::Microsoft.Kiota.Abstractions.Time? DueTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? NotificationChannelUrl { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Education.Client.Models.EducationAddedStudentAction? AddedStudentAction { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Education.Client.Models.EducationAddToCalendarOptions? AddToCalendarAction { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(EducationClassId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Education.Client.Models.EducationAssignmentDefaults();

    if (this.IsParameterBound(nameof(DueTime)))
        body.DueTime = DueTime;

    if (this.IsParameterBound(nameof(NotificationChannelUrl)))
        body.NotificationChannelUrl = NotificationChannelUrl;

    if (this.IsParameterBound(nameof(AddedStudentAction)))
        body.AddedStudentAction = AddedStudentAction;

    if (this.IsParameterBound(nameof(AddToCalendarAction)))
        body.AddToCalendarAction = AddToCalendarAction;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Education.Client.Models.EducationAssignmentDefaults? result;
            try
            {
                result = client.Education.Classes[EducationClassId].AssignmentDefaults.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, EducationClassId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Education.Classes[EducationClassId].AssignmentDefaults.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
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
