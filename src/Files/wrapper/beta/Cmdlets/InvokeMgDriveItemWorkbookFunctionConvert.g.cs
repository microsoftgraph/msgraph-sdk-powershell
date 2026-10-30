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
    [GraphRoute("POST", "/drives/{drive-id}/items/{driveItem-id}/workbook/functions/convert")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDriveItemWorkbookFunctionConvert", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookFunctionResult))]
    public class InvokeMgDriveItemWorkbookFunctionConvertCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DriveItemId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        public object? Number { get; set; }

        [Parameter(Mandatory = false)]
        public object? FromUnit { get; set; }

        [Parameter(Mandatory = false)]
        public object? ToUnit { get; set; }





        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DriveItemId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Files.Client.Drives.Item.Items.Item.Workbook.Functions.ConvertNamespace.ConvertPostRequestBody();

    if (this.IsParameterBound(nameof(Number)))
    {
        var untypedNumber = UntypedValue.From(Number);
        if (untypedNumber is not null)
            body.Number = untypedNumber;
    }

    if (this.IsParameterBound(nameof(FromUnit)))
    {
        var untypedFromUnit = UntypedValue.From(FromUnit);
        if (untypedFromUnit is not null)
            body.FromUnit = untypedFromUnit;
    }

    if (this.IsParameterBound(nameof(ToUnit)))
    {
        var untypedToUnit = UntypedValue.From(ToUnit);
        if (untypedToUnit is not null)
            body.ToUnit = untypedToUnit;
    }

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookFunctionResult? result;
            try
            {
                result = client.Drives[DriveId].Items[DriveItemId].Workbook.Functions.Convert.PostAsync(body, requestConfiguration =>
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
