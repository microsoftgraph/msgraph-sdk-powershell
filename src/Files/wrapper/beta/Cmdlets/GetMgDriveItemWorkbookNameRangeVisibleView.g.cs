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
    [GraphRoute("GET", "/drives/{drive-id}/items/{driveItem-id}/workbook/names/{workbookNamedItem-id}/range()/visibleView()")]
    [Cmdlet(VerbsCommon.Get, "MgDriveItemWorkbookNameRangeVisibleView")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookRangeView))]
    public class GetMgDriveItemWorkbookNameRangeVisibleViewCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DriveItemId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string WorkbookNamedItemId { get; set; } = string.Empty;









        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookRangeView? result;
            try
            {
                result = client.Drives[DriveId].Items[DriveItemId].Workbook.Names[WorkbookNamedItemId].Range.VisibleView.GetAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, WorkbookNamedItemId);
                return;
            }

            WriteObject(result);
        }
    }
}
