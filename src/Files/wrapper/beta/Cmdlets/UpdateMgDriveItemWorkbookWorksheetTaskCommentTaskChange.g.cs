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
    [GraphRoute("PATCH", "/drives/{drive-id}/items/{driveItem-id}/workbook/worksheets/{workbookWorksheet-id}/tasks/{workbookDocumentTask-id}/comment/task/changes/{workbookDocumentTaskChange-id}")]
    [Cmdlet(VerbsData.Update, "MgDriveItemWorkbookWorksheetTaskCommentTaskChange", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookDocumentTaskChange))]
    public class UpdateMgDriveItemWorkbookWorksheetTaskCommentTaskChangeCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DriveItemId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string WorkbookWorksheetId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string WorkbookDocumentTaskId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 4)]
        public string WorkbookDocumentTaskChangeId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? CommentId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? DueDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public int? PercentComplete { get; set; }

        [Parameter(Mandatory = false)]
        public int? Priority { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? StartDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Title { get; set; }

        [Parameter(Mandatory = false)]
        public string? Type { get; set; }

        [Parameter(Mandatory = false)]
        public string? UndoChangeId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookEmailIdentity? Assignee { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookEmailIdentity? ChangedBy { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(WorkbookDocumentTaskChangeId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookDocumentTaskChange();

    if (this.IsParameterBound(nameof(CommentId)))
        body.CommentId = CommentId;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(DueDateTime)))
        body.DueDateTime = DueDateTime;

    if (this.IsParameterBound(nameof(PercentComplete)))
        body.PercentComplete = PercentComplete;

    if (this.IsParameterBound(nameof(Priority)))
        body.Priority = Priority;

    if (this.IsParameterBound(nameof(StartDateTime)))
        body.StartDateTime = StartDateTime;

    if (this.IsParameterBound(nameof(Title)))
        body.Title = Title;

    if (this.IsParameterBound(nameof(Type)))
        body.Type = Type;

    if (this.IsParameterBound(nameof(UndoChangeId)))
        body.UndoChangeId = UndoChangeId;

    if (this.IsParameterBound(nameof(Assignee)))
        body.Assignee = Assignee;

    if (this.IsParameterBound(nameof(ChangedBy)))
        body.ChangedBy = ChangedBy;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookDocumentTaskChange? result;
            try
            {
                result = client.Drives[DriveId].Items[DriveItemId].Workbook.Worksheets[WorkbookWorksheetId].Tasks[WorkbookDocumentTaskId].Comment.Task.Changes[WorkbookDocumentTaskChangeId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, WorkbookDocumentTaskChangeId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Drives[DriveId].Items[DriveItemId].Workbook.Worksheets[WorkbookWorksheetId].Tasks[WorkbookDocumentTaskId].Comment.Task.Changes[WorkbookDocumentTaskChangeId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, WorkbookDocumentTaskChangeId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
