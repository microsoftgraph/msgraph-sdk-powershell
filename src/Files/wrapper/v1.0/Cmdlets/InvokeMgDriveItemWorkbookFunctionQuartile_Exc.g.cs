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
    [GraphRoute("POST", "/drives/{drive-id}/items/{driveItem-id}/workbook/functions/quartile_Exc")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDriveItemWorkbookFunctionQuartile_Exc", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookFunctionResult))]
    public class InvokeMgDriveItemWorkbookFunctionQuartile_ExcCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DriveItemId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        public object? Array { get; set; }

        [Parameter(Mandatory = false)]
        public object? Quart { get; set; }





        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DriveItemId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Files.Client.Drives.Item.Items.Item.Workbook.Functions.Quartile_Exc.Quartile_ExcPostRequestBody();

    if (this.IsParameterBound(nameof(Array)))
    {
        var untypedArray = UntypedValue.From(Array);
        if (untypedArray is not null)
            body.Array = untypedArray;
    }

    if (this.IsParameterBound(nameof(Quart)))
    {
        var untypedQuart = UntypedValue.From(Quart);
        if (untypedQuart is not null)
            body.Quart = untypedQuart;
    }

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookFunctionResult? result;
            try
            {
                result = client.Drives[DriveId].Items[DriveItemId].Workbook.Functions.Quartile_Exc.PostAsync(body, requestConfiguration =>
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
