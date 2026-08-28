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
    [GraphRoute("GET", "/drives/{drive-id}/items/{driveItem-id}/workbook/tables/count()")]
    [Cmdlet(VerbsCommon.Get, "MgDriveItemWorkbookTableCount")]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Files.Client.Drives.Item.Items.Item.Workbook.Tables.Count.CountGetResponse))]
    public class GetMgDriveItemWorkbookTableCountCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DriveItemId { get; set; } = string.Empty;









        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            global::Microsoft.Graph.PowerShell.Files.Client.Drives.Item.Items.Item.Workbook.Tables.Count.CountGetResponse? result;
            try
            {
                result = client.Drives[DriveId].Items[DriveItemId].Workbook.Tables.Count.GetAsCountGetResponseAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, DriveItemId);
                return;
            }

            WriteObject(result);
        }
    }
}
