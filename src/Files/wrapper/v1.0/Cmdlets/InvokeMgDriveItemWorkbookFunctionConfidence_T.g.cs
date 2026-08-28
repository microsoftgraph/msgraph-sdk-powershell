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
    [GraphRoute("POST", "/drives/{drive-id}/items/{driveItem-id}/workbook/functions/confidence_T")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDriveItemWorkbookFunctionConfidence_T", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookFunctionResult))]
    public class InvokeMgDriveItemWorkbookFunctionConfidence_TCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DriveItemId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        public object? Alpha { get; set; }

        [Parameter(Mandatory = false)]
        public object? StandardDev { get; set; }

        [Parameter(Mandatory = false)]
        public object? Size { get; set; }





        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DriveItemId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Files.Client.Drives.Item.Items.Item.Workbook.Functions.Confidence_T.Confidence_TPostRequestBody();

    if (this.IsParameterBound(nameof(Alpha)))
    {
        var untypedAlpha = UntypedValue.From(Alpha);
        if (untypedAlpha is not null)
            body.Alpha = untypedAlpha;
    }

    if (this.IsParameterBound(nameof(StandardDev)))
    {
        var untypedStandardDev = UntypedValue.From(StandardDev);
        if (untypedStandardDev is not null)
            body.StandardDev = untypedStandardDev;
    }

    if (this.IsParameterBound(nameof(Size)))
    {
        var untypedSize = UntypedValue.From(Size);
        if (untypedSize is not null)
            body.Size = untypedSize;
    }

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookFunctionResult? result;
            try
            {
                result = client.Drives[DriveId].Items[DriveItemId].Workbook.Functions.Confidence_T.PostAsync(body, requestConfiguration =>
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
