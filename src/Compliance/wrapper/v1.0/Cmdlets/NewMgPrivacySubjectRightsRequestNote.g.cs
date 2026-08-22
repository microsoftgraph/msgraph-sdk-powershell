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
    [GraphRoute("POST", "/privacy/subjectRightsRequests/{subjectRightsRequest-id}/notes")]
    [Cmdlet(VerbsCommon.New, "MgPrivacySubjectRightsRequestNote", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Compliance.Client.Models.AuthoredNote))]
    public class NewMgPrivacySubjectRightsRequestNoteCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SubjectRightsRequestId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Compliance.Client.Models.Identity? Author { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Compliance.Client.Models.ItemBody? Content { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SubjectRightsRequestId, "New"))
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
                result = client.Privacy.SubjectRightsRequests[SubjectRightsRequestId].Notes.PostAsync(body, requestConfiguration =>
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
