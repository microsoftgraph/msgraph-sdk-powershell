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
    [GraphRoute("POST", "/drives/{drive-id}/items/{driveItem-id}/workbook/functions/sumIf")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDriveItemWorkbookFunctionSumIf", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookFunctionResult))]
    public class InvokeMgDriveItemWorkbookFunctionSumIfCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DriveItemId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        public object? Range { get; set; }

        [Parameter(Mandatory = false)]
        public object? Criteria { get; set; }

        [Parameter(Mandatory = false)]
        public object? SumRange { get; set; }





        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DriveItemId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Files.Client.Drives.Item.Items.Item.Workbook.Functions.SumIf.SumIfPostRequestBody();

    if (this.IsParameterBound(nameof(Range)))
    {
        var untypedRange = UntypedValue.From(Range);
        if (untypedRange is not null)
            body.Range = untypedRange;
    }

    if (this.IsParameterBound(nameof(Criteria)))
    {
        var untypedCriteria = UntypedValue.From(Criteria);
        if (untypedCriteria is not null)
            body.Criteria = untypedCriteria;
    }

    if (this.IsParameterBound(nameof(SumRange)))
    {
        var untypedSumRange = UntypedValue.From(SumRange);
        if (untypedSumRange is not null)
            body.SumRange = untypedSumRange;
    }

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookFunctionResult? result;
            try
            {
                result = client.Drives[DriveId].Items[DriveItemId].Workbook.Functions.SumIf.PostAsync(body, requestConfiguration =>
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
