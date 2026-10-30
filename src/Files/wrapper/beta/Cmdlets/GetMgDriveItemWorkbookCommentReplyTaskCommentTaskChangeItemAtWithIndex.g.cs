#nullable enable

using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Files.Client;
using Microsoft.Graph.PowerShell.Files.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Files
{
    [GraphRoute("GET", "/drives/{drive-id}/items/{driveItem-id}/workbook/comments/{workbookComment-id}/replies/{workbookCommentReply-id}/task/comment/task/changes/itemAt(index={index})")]
    [Cmdlet(VerbsCommon.Get, "MgDriveItemWorkbookCommentReplyTaskCommentTaskChangeItemAtWithIndex")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookDocumentTaskChange))]
    public class GetMgDriveItemWorkbookCommentReplyTaskCommentTaskChangeItemAtWithIndexCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DriveItemId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string WorkbookCommentId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string WorkbookCommentReplyId { get; set; } = string.Empty;

        [Parameter(Mandatory = true, Position = 4,
            HelpMessage = "Value for the 'index' parameter of this OData function.")]
        public string Index { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

        var pathParameters = new Dictionary<string, object>
        {
            { "baseurl", requestAdapter.BaseUrl! },
            { "drive%2Did", DriveId },
            { "driveItem%2Did", DriveItemId },
            { "workbookComment%2Did", WorkbookCommentId },
            { "workbookCommentReply%2Did", WorkbookCommentReplyId },
            { "index", Index },
        };
        var requestBuilder = new global::Microsoft.Graph.PowerShell.Files.Client.Drives.Item.Items.Item.Workbook.Comments.Item.Replies.Item.TaskNamespace.Comment.TaskNamespace.Changes.ItemAtWithIndex.ItemAtWithIndexRequestBuilder(pathParameters, requestAdapter);

            Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookDocumentTaskChange? result;
            try
            {
                result = requestBuilder.GetAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, WorkbookCommentReplyId);
                return;
            }

            WriteObject(result);
        }
    }
}
