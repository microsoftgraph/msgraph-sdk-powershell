#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Compliance.Client;
using Microsoft.Graph.PowerShell.Compliance.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Compliance
{
    [GraphRoute("PATCH", "/privacy/subjectRightsRequests/{subjectRightsRequest-id}/notes/{authoredNote-id}")]
    [Cmdlet(VerbsData.Update, "MgPrivacySubjectRightsRequestNote", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Compliance.Client.Models.AuthoredNote))]
    public class UpdateMgPrivacySubjectRightsRequestNoteCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SubjectRightsRequestId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string AuthoredNoteId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Compliance.Client.Models.Identity? Author { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Compliance.Client.Models.ItemBody? Content { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AuthoredNoteId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Compliance.Client.Models.AuthoredNote();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(Author)))
        body.Author = Author;

    if (this.IsParameterBound(nameof(Content)))
        body.Content = Content;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Compliance.Client.Models.AuthoredNote? result;
            try
            {
                result = client.Privacy.SubjectRightsRequests[SubjectRightsRequestId].Notes[AuthoredNoteId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, AuthoredNoteId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Privacy.SubjectRightsRequests[SubjectRightsRequestId].Notes[AuthoredNoteId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, AuthoredNoteId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
