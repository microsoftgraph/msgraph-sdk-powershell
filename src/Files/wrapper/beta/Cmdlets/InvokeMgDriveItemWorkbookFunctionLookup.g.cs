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
    [GraphRoute("POST", "/drives/{drive-id}/items/{driveItem-id}/workbook/functions/lookup")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDriveItemWorkbookFunctionLookup", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookFunctionResult))]
    public class InvokeMgDriveItemWorkbookFunctionLookupCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DriveItemId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        public object? LookupValue { get; set; }

        [Parameter(Mandatory = false)]
        public object? LookupVector { get; set; }

        [Parameter(Mandatory = false)]
        public object? ResultVector { get; set; }





        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DriveItemId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Files.Client.Drives.Item.Items.Item.Workbook.Functions.Lookup.LookupPostRequestBody();

    if (this.IsParameterBound(nameof(LookupValue)))
    {
        var untypedLookupValue = UntypedValue.From(LookupValue);
        if (untypedLookupValue is not null)
            body.LookupValue = untypedLookupValue;
    }

    if (this.IsParameterBound(nameof(LookupVector)))
    {
        var untypedLookupVector = UntypedValue.From(LookupVector);
        if (untypedLookupVector is not null)
            body.LookupVector = untypedLookupVector;
    }

    if (this.IsParameterBound(nameof(ResultVector)))
    {
        var untypedResultVector = UntypedValue.From(ResultVector);
        if (untypedResultVector is not null)
            body.ResultVector = untypedResultVector;
    }

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookFunctionResult? result;
            try
            {
                result = client.Drives[DriveId].Items[DriveItemId].Workbook.Functions.Lookup.PostAsync(body, requestConfiguration =>
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
