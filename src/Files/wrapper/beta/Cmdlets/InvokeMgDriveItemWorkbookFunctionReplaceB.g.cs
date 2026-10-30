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
    [GraphRoute("POST", "/drives/{drive-id}/items/{driveItem-id}/workbook/functions/replaceB")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDriveItemWorkbookFunctionReplaceB", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookFunctionResult))]
    public class InvokeMgDriveItemWorkbookFunctionReplaceBCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DriveItemId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        public object? OldText { get; set; }

        [Parameter(Mandatory = false)]
        public object? StartNum { get; set; }

        [Parameter(Mandatory = false)]
        public object? NumBytes { get; set; }

        [Parameter(Mandatory = false)]
        public object? NewText { get; set; }





        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DriveItemId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Files.Client.Drives.Item.Items.Item.Workbook.Functions.ReplaceB.ReplaceBPostRequestBody();

    if (this.IsParameterBound(nameof(OldText)))
    {
        var untypedOldText = UntypedValue.From(OldText);
        if (untypedOldText is not null)
            body.OldText = untypedOldText;
    }

    if (this.IsParameterBound(nameof(StartNum)))
    {
        var untypedStartNum = UntypedValue.From(StartNum);
        if (untypedStartNum is not null)
            body.StartNum = untypedStartNum;
    }

    if (this.IsParameterBound(nameof(NumBytes)))
    {
        var untypedNumBytes = UntypedValue.From(NumBytes);
        if (untypedNumBytes is not null)
            body.NumBytes = untypedNumBytes;
    }

    if (this.IsParameterBound(nameof(NewText)))
    {
        var untypedNewText = UntypedValue.From(NewText);
        if (untypedNewText is not null)
            body.NewText = untypedNewText;
    }

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookFunctionResult? result;
            try
            {
                result = client.Drives[DriveId].Items[DriveItemId].Workbook.Functions.ReplaceB.PostAsync(body, requestConfiguration =>
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
