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
    [GraphRoute("POST", "/drives/{drive-id}/items/{driveItem-id}/workbook/functions/syd")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDriveItemWorkbookFunctionSyd", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookFunctionResult))]
    public class InvokeMgDriveItemWorkbookFunctionSydCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DriveItemId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        public object? Cost { get; set; }

        [Parameter(Mandatory = false)]
        public object? Salvage { get; set; }

        [Parameter(Mandatory = false)]
        public object? Life { get; set; }

        [Parameter(Mandatory = false)]
        public object? Per { get; set; }





        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DriveItemId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Files.Client.Drives.Item.Items.Item.Workbook.Functions.Syd.SydPostRequestBody();

    if (this.IsParameterBound(nameof(Cost)))
    {
        var untypedCost = UntypedValue.From(Cost);
        if (untypedCost is not null)
            body.Cost = untypedCost;
    }

    if (this.IsParameterBound(nameof(Salvage)))
    {
        var untypedSalvage = UntypedValue.From(Salvage);
        if (untypedSalvage is not null)
            body.Salvage = untypedSalvage;
    }

    if (this.IsParameterBound(nameof(Life)))
    {
        var untypedLife = UntypedValue.From(Life);
        if (untypedLife is not null)
            body.Life = untypedLife;
    }

    if (this.IsParameterBound(nameof(Per)))
    {
        var untypedPer = UntypedValue.From(Per);
        if (untypedPer is not null)
            body.Per = untypedPer;
    }

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookFunctionResult? result;
            try
            {
                result = client.Drives[DriveId].Items[DriveItemId].Workbook.Functions.Syd.PostAsync(body, requestConfiguration =>
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
