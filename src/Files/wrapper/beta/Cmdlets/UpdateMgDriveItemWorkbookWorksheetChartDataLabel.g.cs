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
    [GraphRoute("PATCH", "/drives/{drive-id}/items/{driveItem-id}/workbook/worksheets/{workbookWorksheet-id}/charts/{workbookChart-id}/dataLabels")]
    [Cmdlet(VerbsData.Update, "MgDriveItemWorkbookWorksheetChartDataLabel", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookChartDataLabels))]
    public class UpdateMgDriveItemWorkbookWorksheetChartDataLabelCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DriveItemId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string WorkbookWorksheetId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string WorkbookChartId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Position { get; set; }

        [Parameter(Mandatory = false)]
        public string? Separator { get; set; }

        [Parameter(Mandatory = false)]
        public bool? ShowBubbleSize { get; set; }

        [Parameter(Mandatory = false)]
        public bool? ShowCategoryName { get; set; }

        [Parameter(Mandatory = false)]
        public bool? ShowLegendKey { get; set; }

        [Parameter(Mandatory = false)]
        public bool? ShowPercentage { get; set; }

        [Parameter(Mandatory = false)]
        public bool? ShowSeriesName { get; set; }

        [Parameter(Mandatory = false)]
        public bool? ShowValue { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(WorkbookChartId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookChartDataLabels();

    if (this.IsParameterBound(nameof(Position)))
        body.Position = Position;

    if (this.IsParameterBound(nameof(Separator)))
        body.Separator = Separator;

    if (this.IsParameterBound(nameof(ShowBubbleSize)))
        body.ShowBubbleSize = ShowBubbleSize;

    if (this.IsParameterBound(nameof(ShowCategoryName)))
        body.ShowCategoryName = ShowCategoryName;

    if (this.IsParameterBound(nameof(ShowLegendKey)))
        body.ShowLegendKey = ShowLegendKey;

    if (this.IsParameterBound(nameof(ShowPercentage)))
        body.ShowPercentage = ShowPercentage;

    if (this.IsParameterBound(nameof(ShowSeriesName)))
        body.ShowSeriesName = ShowSeriesName;

    if (this.IsParameterBound(nameof(ShowValue)))
        body.ShowValue = ShowValue;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookChartDataLabels? result;
            try
            {
                result = client.Drives[DriveId].Items[DriveItemId].Workbook.Worksheets[WorkbookWorksheetId].Charts[WorkbookChartId].DataLabels.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, WorkbookChartId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Drives[DriveId].Items[DriveItemId].Workbook.Worksheets[WorkbookWorksheetId].Charts[WorkbookChartId].DataLabels.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, WorkbookChartId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
