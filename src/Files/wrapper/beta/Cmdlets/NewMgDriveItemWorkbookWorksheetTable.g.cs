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
    [GraphRoute("POST", "/drives/{drive-id}/items/{driveItem-id}/workbook/worksheets/{workbookWorksheet-id}/tables")]
    [Cmdlet(VerbsCommon.New, "MgDriveItemWorkbookWorksheetTable", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookTable))]
    public class NewMgDriveItemWorkbookWorksheetTableCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DriveItemId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string WorkbookWorksheetId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? HighlightFirstColumn { get; set; }

        [Parameter(Mandatory = false)]
        public bool? HighlightLastColumn { get; set; }

        [Parameter(Mandatory = false)]
        public string? LegacyId { get; set; }

        [Parameter(Mandatory = false)]
        public string? Name { get; set; }

        [Parameter(Mandatory = false)]
        public bool? ShowBandedColumns { get; set; }

        [Parameter(Mandatory = false)]
        public bool? ShowBandedRows { get; set; }

        [Parameter(Mandatory = false)]
        public bool? ShowFilterButton { get; set; }

        [Parameter(Mandatory = false)]
        public bool? ShowHeaders { get; set; }

        [Parameter(Mandatory = false)]
        public bool? ShowTotals { get; set; }

        [Parameter(Mandatory = false)]
        public string? Style { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(WorkbookWorksheetId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookTable();

    if (this.IsParameterBound(nameof(HighlightFirstColumn)))
        body.HighlightFirstColumn = HighlightFirstColumn;

    if (this.IsParameterBound(nameof(HighlightLastColumn)))
        body.HighlightLastColumn = HighlightLastColumn;

    if (this.IsParameterBound(nameof(LegacyId)))
        body.LegacyId = LegacyId;

    if (this.IsParameterBound(nameof(Name)))
        body.Name = Name;

    if (this.IsParameterBound(nameof(ShowBandedColumns)))
        body.ShowBandedColumns = ShowBandedColumns;

    if (this.IsParameterBound(nameof(ShowBandedRows)))
        body.ShowBandedRows = ShowBandedRows;

    if (this.IsParameterBound(nameof(ShowFilterButton)))
        body.ShowFilterButton = ShowFilterButton;

    if (this.IsParameterBound(nameof(ShowHeaders)))
        body.ShowHeaders = ShowHeaders;

    if (this.IsParameterBound(nameof(ShowTotals)))
        body.ShowTotals = ShowTotals;

    if (this.IsParameterBound(nameof(Style)))
        body.Style = Style;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookTable? result;
            try
            {
                result = client.Drives[DriveId].Items[DriveItemId].Workbook.Worksheets[WorkbookWorksheetId].Tables.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
