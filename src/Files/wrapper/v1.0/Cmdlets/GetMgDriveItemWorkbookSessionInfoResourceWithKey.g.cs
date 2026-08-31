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
    [GraphRoute("GET", "/drives/{drive-id}/items/{driveItem-id}/workbook/sessionInfoResource(key='{key}')")]
    [Cmdlet(VerbsCommon.Get, "MgDriveItemWorkbookSessionInfoResourceWithKey")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookSessionInfo))]
    public class GetMgDriveItemWorkbookSessionInfoResourceWithKeyCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DriveItemId { get; set; } = string.Empty;

        [Parameter(Mandatory = true, Position = 2,
            HelpMessage = "Value for the 'key' parameter of this OData function.")]
        public string Key { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

        var pathParameters = new Dictionary<string, object>
        {
            { "baseurl", requestAdapter.BaseUrl! },
            { "drive%2Did", DriveId },
            { "driveItem%2Did", DriveItemId },
            { "key", Key },
        };
        var requestBuilder = new global::Microsoft.Graph.PowerShell.Files.Client.Drives.Item.Items.Item.Workbook.SessionInfoResourceWithKey.SessionInfoResourceWithKeyRequestBuilder(pathParameters, requestAdapter);

            Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookSessionInfo? result;
            try
            {
                result = requestBuilder.GetAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DriveItemId);
                return;
            }

            WriteObject(result);
        }
    }
}
