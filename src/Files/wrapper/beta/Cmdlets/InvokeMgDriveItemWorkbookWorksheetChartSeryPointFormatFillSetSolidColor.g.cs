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
    [GraphRoute("POST", "/drives/{drive-id}/items/{driveItem-id}/workbook/worksheets/{workbookWorksheet-id}/charts/{workbookChart-id}/series/{workbookChartSeries-id}/points/{workbookChartPoint-id}/format/fill/setSolidColor")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDriveItemWorkbookWorksheetChartSeryPointFormatFillSetSolidColor", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgDriveItemWorkbookWorksheetChartSeryPointFormatFillSetSolidColorCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DriveItemId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string WorkbookWorksheetId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string WorkbookChartId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 4)]
        public string WorkbookChartSeriesId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 5)]
        public string WorkbookChartPointId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Color { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(WorkbookChartPointId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Files.Client.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.Item.Series.Item.Points.Item.Format.Fill.SetSolidColor.SetSolidColorPostRequestBody();

    if (this.IsParameterBound(nameof(Color)))
        body.Color = Color;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Drives[DriveId].Items[DriveItemId].Workbook.Worksheets[WorkbookWorksheetId].Charts[WorkbookChartId].Series[WorkbookChartSeriesId].Points[WorkbookChartPointId].Format.Fill.SetSolidColor.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, WorkbookChartPointId);
                return;
            }

        }
    }
}
