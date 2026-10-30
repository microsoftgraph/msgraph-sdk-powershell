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
    [GraphRoute("POST", "/drives/{drive-id}/items/{driveItem-id}/workbook/functions/hlookup")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDriveItemWorkbookFunctionHlookup", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookFunctionResult))]
    public class InvokeMgDriveItemWorkbookFunctionHlookupCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DriveItemId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        public object? LookupValue { get; set; }

        [Parameter(Mandatory = false)]
        public object? TableArray { get; set; }

        [Parameter(Mandatory = false)]
        public object? RowIndexNum { get; set; }

        [Parameter(Mandatory = false)]
        public object? RangeLookup { get; set; }





        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DriveItemId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Files.Client.Drives.Item.Items.Item.Workbook.Functions.Hlookup.HlookupPostRequestBody();

    if (this.IsParameterBound(nameof(LookupValue)))
    {
        var untypedLookupValue = UntypedValue.From(LookupValue);
        if (untypedLookupValue is not null)
            body.LookupValue = untypedLookupValue;
    }

    if (this.IsParameterBound(nameof(TableArray)))
    {
        var untypedTableArray = UntypedValue.From(TableArray);
        if (untypedTableArray is not null)
            body.TableArray = untypedTableArray;
    }

    if (this.IsParameterBound(nameof(RowIndexNum)))
    {
        var untypedRowIndexNum = UntypedValue.From(RowIndexNum);
        if (untypedRowIndexNum is not null)
            body.RowIndexNum = untypedRowIndexNum;
    }

    if (this.IsParameterBound(nameof(RangeLookup)))
    {
        var untypedRangeLookup = UntypedValue.From(RangeLookup);
        if (untypedRangeLookup is not null)
            body.RangeLookup = untypedRangeLookup;
    }

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookFunctionResult? result;
            try
            {
                result = client.Drives[DriveId].Items[DriveItemId].Workbook.Functions.Hlookup.PostAsync(body, requestConfiguration =>
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
