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
    [GraphRoute("POST", "/drives/{drive-id}/items/{driveItem-id}/workbook/functions/if")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDriveItemWorkbookFunctionIf", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookFunctionResult))]
    public class InvokeMgDriveItemWorkbookFunctionIfCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DriveItemId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        public object? LogicalTest { get; set; }

        [Parameter(Mandatory = false)]
        public object? ValueIfTrue { get; set; }

        [Parameter(Mandatory = false)]
        public object? ValueIfFalse { get; set; }





        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DriveItemId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Files.Client.Drives.Item.Items.Item.Workbook.Functions.If.IfPostRequestBody();

    if (this.IsParameterBound(nameof(LogicalTest)))
    {
        var untypedLogicalTest = UntypedValue.From(LogicalTest);
        if (untypedLogicalTest is not null)
            body.LogicalTest = untypedLogicalTest;
    }

    if (this.IsParameterBound(nameof(ValueIfTrue)))
    {
        var untypedValueIfTrue = UntypedValue.From(ValueIfTrue);
        if (untypedValueIfTrue is not null)
            body.ValueIfTrue = untypedValueIfTrue;
    }

    if (this.IsParameterBound(nameof(ValueIfFalse)))
    {
        var untypedValueIfFalse = UntypedValue.From(ValueIfFalse);
        if (untypedValueIfFalse is not null)
            body.ValueIfFalse = untypedValueIfFalse;
    }

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookFunctionResult? result;
            try
            {
                result = client.Drives[DriveId].Items[DriveItemId].Workbook.Functions.If.PostAsync(body, requestConfiguration =>
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
