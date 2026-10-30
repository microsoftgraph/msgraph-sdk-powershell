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
    [GraphRoute("POST", "/drives/{drive-id}/items/{driveItem-id}/workbook/functions/amorLinc")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDriveItemWorkbookFunctionAmorLinc", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookFunctionResult))]
    public class InvokeMgDriveItemWorkbookFunctionAmorLincCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DriveItemId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        public object? Cost { get; set; }

        [Parameter(Mandatory = false)]
        public object? DatePurchased { get; set; }

        [Parameter(Mandatory = false)]
        public object? FirstPeriod { get; set; }

        [Parameter(Mandatory = false)]
        public object? Salvage { get; set; }

        [Parameter(Mandatory = false)]
        public object? Period { get; set; }

        [Parameter(Mandatory = false)]
        public object? Rate { get; set; }

        [Parameter(Mandatory = false)]
        public object? Basis { get; set; }





        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DriveItemId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Files.Client.Drives.Item.Items.Item.Workbook.Functions.AmorLinc.AmorLincPostRequestBody();

    if (this.IsParameterBound(nameof(Cost)))
    {
        var untypedCost = UntypedValue.From(Cost);
        if (untypedCost is not null)
            body.Cost = untypedCost;
    }

    if (this.IsParameterBound(nameof(DatePurchased)))
    {
        var untypedDatePurchased = UntypedValue.From(DatePurchased);
        if (untypedDatePurchased is not null)
            body.DatePurchased = untypedDatePurchased;
    }

    if (this.IsParameterBound(nameof(FirstPeriod)))
    {
        var untypedFirstPeriod = UntypedValue.From(FirstPeriod);
        if (untypedFirstPeriod is not null)
            body.FirstPeriod = untypedFirstPeriod;
    }

    if (this.IsParameterBound(nameof(Salvage)))
    {
        var untypedSalvage = UntypedValue.From(Salvage);
        if (untypedSalvage is not null)
            body.Salvage = untypedSalvage;
    }

    if (this.IsParameterBound(nameof(Period)))
    {
        var untypedPeriod = UntypedValue.From(Period);
        if (untypedPeriod is not null)
            body.Period = untypedPeriod;
    }

    if (this.IsParameterBound(nameof(Rate)))
    {
        var untypedRate = UntypedValue.From(Rate);
        if (untypedRate is not null)
            body.Rate = untypedRate;
    }

    if (this.IsParameterBound(nameof(Basis)))
    {
        var untypedBasis = UntypedValue.From(Basis);
        if (untypedBasis is not null)
            body.Basis = untypedBasis;
    }

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookFunctionResult? result;
            try
            {
                result = client.Drives[DriveId].Items[DriveItemId].Workbook.Functions.AmorLinc.PostAsync(body, requestConfiguration =>
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
