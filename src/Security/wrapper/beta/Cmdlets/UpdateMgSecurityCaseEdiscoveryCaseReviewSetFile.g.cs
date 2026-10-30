#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Security.Client;
using Microsoft.Graph.PowerShell.Security.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Security
{
    [GraphRoute("PATCH", "/security/cases/ediscoveryCases/{ediscoveryCase-id}/reviewSets/{ediscoveryReviewSet-id}/files/{ediscoveryFile-id}")]
    [Cmdlet(VerbsData.Update, "MgSecurityCaseEdiscoveryCaseReviewSetFile", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.Security.EdiscoveryFile))]
    public class UpdateMgSecurityCaseEdiscoveryCaseReviewSetFileCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string EdiscoveryCaseId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string EdiscoveryReviewSetId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string EdiscoveryFileId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public byte[]? Content { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? DateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Extension { get; set; }

        [Parameter(Mandatory = false)]
        public byte[]? ExtractedTextContent { get; set; }

        [Parameter(Mandatory = false)]
        public string? MediaType { get; set; }

        [Parameter(Mandatory = false)]
        public string? Name { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? SenderOrAuthors { get; set; }

        [Parameter(Mandatory = false)]
        public long? Size { get; set; }

        [Parameter(Mandatory = false)]
        public string? SubjectTitle { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.StringValueDictionary? OtherProperties { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.FileProcessingStatus? ProcessingStatus { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.SourceType? SourceType { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(EdiscoveryFileId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Security.Client.Models.Security.EdiscoveryFile();

    if (this.IsParameterBound(nameof(Content)))
        body.Content = Content;

    if (this.IsParameterBound(nameof(DateTime)))
        body.DateTime = DateTime;

    if (this.IsParameterBound(nameof(Extension)))
        body.Extension = Extension;

    if (this.IsParameterBound(nameof(ExtractedTextContent)))
        body.ExtractedTextContent = ExtractedTextContent;

    if (this.IsParameterBound(nameof(MediaType)))
        body.MediaType = MediaType;

    if (this.IsParameterBound(nameof(Name)))
        body.Name = Name;

    if (this.IsParameterBound(nameof(SenderOrAuthors)))
        body.SenderOrAuthors = SenderOrAuthors!.ToList();

    if (this.IsParameterBound(nameof(Size)))
        body.Size = Size;

    if (this.IsParameterBound(nameof(SubjectTitle)))
        body.SubjectTitle = SubjectTitle;

    if (this.IsParameterBound(nameof(OtherProperties)))
        body.OtherProperties = OtherProperties;

    if (this.IsParameterBound(nameof(ProcessingStatus)))
        body.ProcessingStatus = ProcessingStatus;

    if (this.IsParameterBound(nameof(SourceType)))
        body.SourceType = SourceType;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.Security.EdiscoveryFile? result;
            try
            {
                result = client.Security.Cases.EdiscoveryCases[EdiscoveryCaseId].ReviewSets[EdiscoveryReviewSetId].Files[EdiscoveryFileId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, EdiscoveryFileId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Security.Cases.EdiscoveryCases[EdiscoveryCaseId].ReviewSets[EdiscoveryReviewSetId].Files[EdiscoveryFileId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, EdiscoveryFileId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
