#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
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
    [GraphRoute("POST", "/education/me/assignments/{educationAssignment-id}/setUpFeedbackResourcesFolder")]
    [Cmdlet(VerbsCommon.Set, "MgEducationMeAssignmentUpFeedbackResourceFolder", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Education.Client.Models.EducationAssignment))]
    public class SetMgEducationMeAssignmentUpFeedbackResourceFolderCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string EducationAssignmentId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(EducationAssignmentId, "Set"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Education.Client.Models.EducationAssignment? result;
            try
            {
                result = client.Education.Me.Assignments[EducationAssignmentId].SetUpFeedbackResourcesFolder.PostAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, EducationAssignmentId);
                return;
            }

            WriteObject(result);
        }
    }
}
