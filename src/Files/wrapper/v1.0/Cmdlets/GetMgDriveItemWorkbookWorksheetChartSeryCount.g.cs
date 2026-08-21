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
    [GraphRoute("GET", "/drives/{drive-id}/items/{driveItem-id}/workbook/worksheets/{workbookWorksheet-id}/charts/{workbookChart-id}/series/count()")]
    [Cmdlet(VerbsCommon.Get, "MgDriveItemWorkbookWorksheetChartSeryCount")]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Files.Client.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.Item.Series.Count.CountGetResponse))]
    public class GetMgDriveItemWorkbookWorksheetChartSeryCountCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DriveItemId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string WorkbookWorksheetId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string WorkbookChartId { get; set; } = string.Empty;









        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            global::Microsoft.Graph.PowerShell.Files.Client.Drives.Item.Items.Item.Workbook.Worksheets.Item.Charts.Item.Series.Count.CountGetResponse? result;
            try
            {
                result = client.Drives[DriveId].Items[DriveItemId].Workbook.Worksheets[WorkbookWorksheetId].Charts[WorkbookChartId].Series.Count.GetAsCountGetResponseAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, WorkbookChartId);
                return;
            }

            WriteObject(result);
        }
    }
}
