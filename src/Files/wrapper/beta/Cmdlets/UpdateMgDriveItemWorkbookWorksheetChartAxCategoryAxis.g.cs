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
    [GraphRoute("PATCH", "/drives/{drive-id}/items/{driveItem-id}/workbook/worksheets/{workbookWorksheet-id}/charts/{workbookChart-id}/axes/categoryAxis")]
    [Cmdlet(VerbsData.Update, "MgDriveItemWorkbookWorksheetChartAxCategoryAxis", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookChartAxis))]
    public class UpdateMgDriveItemWorkbookWorksheetChartAxCategoryAxisCommand : GraphClientCmdlet
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
        public object? MajorUnit { get; set; }

        [Parameter(Mandatory = false)]
        public object? Maximum { get; set; }

        [Parameter(Mandatory = false)]
        public object? Minimum { get; set; }

        [Parameter(Mandatory = false)]
        public object? MinorUnit { get; set; }





        protected override void ProcessRecord()
        {
            if (!ShouldProcess(WorkbookChartId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookChartAxis();



    if (this.IsParameterBound(nameof(MajorUnit)))
    {
        var untypedMajorUnit = UntypedValue.From(MajorUnit);
        if (untypedMajorUnit is not null)
            body.MajorUnit = untypedMajorUnit;
    }

    if (this.IsParameterBound(nameof(Maximum)))
    {
        var untypedMaximum = UntypedValue.From(Maximum);
        if (untypedMaximum is not null)
            body.Maximum = untypedMaximum;
    }

    if (this.IsParameterBound(nameof(Minimum)))
    {
        var untypedMinimum = UntypedValue.From(Minimum);
        if (untypedMinimum is not null)
            body.Minimum = untypedMinimum;
    }

    if (this.IsParameterBound(nameof(MinorUnit)))
    {
        var untypedMinorUnit = UntypedValue.From(MinorUnit);
        if (untypedMinorUnit is not null)
            body.MinorUnit = untypedMinorUnit;
    }

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookChartAxis? result;
            try
            {
                result = client.Drives[DriveId].Items[DriveItemId].Workbook.Worksheets[WorkbookWorksheetId].Charts[WorkbookChartId].Axes.CategoryAxis.PatchAsync(body, requestConfiguration =>
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
                    result = client.Drives[DriveId].Items[DriveItemId].Workbook.Worksheets[WorkbookWorksheetId].Charts[WorkbookChartId].Axes.CategoryAxis.GetAsync().GetAwaiter().GetResult();
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
