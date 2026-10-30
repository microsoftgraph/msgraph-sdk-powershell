#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
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
    [GraphRoute("POST", "/drives/{drive-id}/items/{driveItem-id}/workbook/worksheets/{workbookWorksheet-id}/tables/{workbookTable-id}/columns/{workbookTableColumn-id}/filter/applyTopItemsFilter")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDriveItemWorkbookWorksheetTableColumnFilterApplyTopItemsFilter", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgDriveItemWorkbookWorksheetTableColumnFilterApplyTopItemsFilterCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DriveItemId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string WorkbookWorksheetId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string WorkbookTableId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 4)]
        public string WorkbookTableColumnId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public int? Count { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(WorkbookTableColumnId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Files.Client.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.Columns.Item.Filter.ApplyTopItemsFilter.ApplyTopItemsFilterPostRequestBody();

    if (this.IsParameterBound(nameof(Count)))
        body.Count = Count;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Drives[DriveId].Items[DriveItemId].Workbook.Worksheets[WorkbookWorksheetId].Tables[WorkbookTableId].Columns[WorkbookTableColumnId].Filter.ApplyTopItemsFilter.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, WorkbookTableColumnId);
                return;
            }

        }
    }
}
