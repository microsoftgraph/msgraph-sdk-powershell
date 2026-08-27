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
    [GraphRoute("POST", "/education/me/assignments/{educationAssignment-id}/submissions")]
    [Cmdlet(VerbsCommon.New, "MgEducationMeAssignmentSubmission", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Education.Client.Models.EducationSubmission))]
    public class NewMgEducationMeAssignmentSubmissionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string EducationAssignmentId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Education.Client.Models.EducationSubmissionRecipient? Recipient { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(EducationAssignmentId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Education.Client.Models.EducationSubmission();


    if (this.IsParameterBound(nameof(Recipient)))
        body.Recipient = Recipient;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Education.Client.Models.EducationSubmission? result;
            try
            {
                result = client.Education.Me.Assignments[EducationAssignmentId].Submissions.PostAsync(body, requestConfiguration =>
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
