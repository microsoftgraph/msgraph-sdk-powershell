#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Files.Client;
using Microsoft.Graph.PowerShell.Files.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Files
{
    [GraphRoute("PATCH", "/drives/{drive-id}/items/{driveItem-id}/workbook/comments/{workbookComment-id}/task/comment/replies/{workbookCommentReply-id}")]
    [Cmdlet(VerbsData.Update, "MgDriveItemWorkbookCommentTaskCommentReply", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookCommentReply))]
    public class UpdateMgDriveItemWorkbookCommentTaskCommentReplyCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DriveItemId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string WorkbookCommentId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string WorkbookCommentReplyId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Content { get; set; }

        [Parameter(Mandatory = false)]
        public string? ContentType { get; set; }

        [Parameter(Mandatory = false)]
        public string? RichContent { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookCommentMention[]? Mentions { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(WorkbookCommentReplyId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookCommentReply();

    if (this.IsParameterBound(nameof(Content)))
        body.Content = Content;

    if (this.IsParameterBound(nameof(ContentType)))
        body.ContentType = ContentType;

    if (this.IsParameterBound(nameof(RichContent)))
        body.RichContent = RichContent;

    if (this.IsParameterBound(nameof(Mentions)))
        body.Mentions = Mentions!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookCommentReply? result;
            try
            {
                result = client.Drives[DriveId].Items[DriveItemId].Workbook.Comments[WorkbookCommentId].Task.Comment.Replies[WorkbookCommentReplyId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, WorkbookCommentReplyId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Drives[DriveId].Items[DriveItemId].Workbook.Comments[WorkbookCommentId].Task.Comment.Replies[WorkbookCommentReplyId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, WorkbookCommentReplyId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
