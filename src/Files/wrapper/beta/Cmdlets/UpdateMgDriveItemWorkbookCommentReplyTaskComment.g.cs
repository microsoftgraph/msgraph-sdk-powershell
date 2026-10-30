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
    [GraphRoute("PATCH", "/drives/{drive-id}/items/{driveItem-id}/workbook/comments/{workbookComment-id}/replies/{workbookCommentReply-id}/task/comment")]
    [Cmdlet(VerbsData.Update, "MgDriveItemWorkbookCommentReplyTaskComment", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookComment))]
    public class UpdateMgDriveItemWorkbookCommentReplyTaskCommentCommand : GraphClientCmdlet
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
        public string? CellAddress { get; set; }

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

            var body = new Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookComment();

    if (this.IsParameterBound(nameof(CellAddress)))
        body.CellAddress = CellAddress;

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

            Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookComment? result;
            try
            {
                result = client.Drives[DriveId].Items[DriveItemId].Workbook.Comments[WorkbookCommentId].Replies[WorkbookCommentReplyId].Task.Comment.PatchAsync(body, requestConfiguration =>
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
                    result = client.Drives[DriveId].Items[DriveItemId].Workbook.Comments[WorkbookCommentId].Replies[WorkbookCommentReplyId].Task.Comment.GetAsync().GetAwaiter().GetResult();
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
