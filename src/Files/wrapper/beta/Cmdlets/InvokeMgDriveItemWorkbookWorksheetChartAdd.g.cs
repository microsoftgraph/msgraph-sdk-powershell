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
    [GraphRoute("POST", "/drives/{drive-id}/items/{driveItem-id}/workbook/worksheets/{workbookWorksheet-id}/charts/add")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDriveItemWorkbookWorksheetChartAdd", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookChart))]
    public class InvokeMgDriveItemWorkbookWorksheetChartAddCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DriveItemId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string WorkbookWorksheetId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Type { get; set; }

        [Parameter(Mandatory = false)]
        public string? SeriesBy { get; set; }


        [Parameter(Mandatory = false)]
        public object? SourceData { get; set; }





        protected override void ProcessRecord()
        {
            if (!ShouldProcess(WorkbookWorksheetId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Files.Client.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.Add.AddPostRequestBody();

    if (this.IsParameterBound(nameof(Type)))
        body.Type = Type;

    if (this.IsParameterBound(nameof(SeriesBy)))
        body.SeriesBy = SeriesBy;
    if (this.IsParameterBound(nameof(SourceData)))
    {
        var untypedSourceData = UntypedValue.From(SourceData);
        if (untypedSourceData is not null)
            body.SourceData = untypedSourceData;
    }

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookChart? result;
            try
            {
                result = client.Drives[DriveId].Items[DriveItemId].Workbook.Worksheets[WorkbookWorksheetId].Charts.Add.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, WorkbookWorksheetId);
                return;
            }

            WriteObject(result);
        }
    }
}
