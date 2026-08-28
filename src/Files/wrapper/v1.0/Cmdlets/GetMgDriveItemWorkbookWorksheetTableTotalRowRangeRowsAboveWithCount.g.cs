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
    [GraphRoute("GET", "/drives/{drive-id}/items/{driveItem-id}/workbook/worksheets/{workbookWorksheet-id}/tables/{workbookTable-id}/totalRowRange()/rowsAbove(count={count})")]
    [Cmdlet(VerbsCommon.Get, "MgDriveItemWorkbookWorksheetTableTotalRowRangeRowsAboveWithCount")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookRange))]
    public class GetMgDriveItemWorkbookWorksheetTableTotalRowRangeRowsAboveWithCountCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DriveItemId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string WorkbookWorksheetId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string WorkbookTableId { get; set; } = string.Empty;

        [Parameter(Mandatory = true, Position = 4,
            HelpMessage = "Value for the 'count' parameter of this OData function.")]
        public string Count { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

        var pathParameters = new Dictionary<string, object>
        {
            { "baseurl", requestAdapter.BaseUrl! },
            { "drive%2Did", DriveId },
            { "driveItem%2Did", DriveItemId },
            { "workbookWorksheet%2Did", WorkbookWorksheetId },
            { "workbookTable%2Did", WorkbookTableId },
            { "count", Count },
        };
        var requestBuilder = new global::Microsoft.Graph.PowerShell.Files.Client.Drives.Item.Items.Item.Workbook.Worksheets.Item.Tables.Item.TotalRowRange.RowsAboveWithCount.RowsAboveWithCountRequestBuilder(pathParameters, requestAdapter);

            Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookRange? result;
            try
            {
                result = requestBuilder.GetAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, WorkbookTableId);
                return;
            }

            WriteObject(result);
        }
    }
}
