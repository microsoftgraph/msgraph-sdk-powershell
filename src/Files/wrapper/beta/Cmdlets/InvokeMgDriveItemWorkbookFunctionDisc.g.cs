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
    [GraphRoute("POST", "/drives/{drive-id}/items/{driveItem-id}/workbook/functions/disc")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDriveItemWorkbookFunctionDisc", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookFunctionResult))]
    public class InvokeMgDriveItemWorkbookFunctionDiscCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DriveItemId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        public object? Settlement { get; set; }

        [Parameter(Mandatory = false)]
        public object? Maturity { get; set; }

        [Parameter(Mandatory = false)]
        public object? Pr { get; set; }

        [Parameter(Mandatory = false)]
        public object? Redemption { get; set; }

        [Parameter(Mandatory = false)]
        public object? Basis { get; set; }





        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DriveItemId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Files.Client.Drives.Item.Items.Item.Workbook.Functions.Disc.DiscPostRequestBody();

    if (this.IsParameterBound(nameof(Settlement)))
    {
        var untypedSettlement = UntypedValue.From(Settlement);
        if (untypedSettlement is not null)
            body.Settlement = untypedSettlement;
    }

    if (this.IsParameterBound(nameof(Maturity)))
    {
        var untypedMaturity = UntypedValue.From(Maturity);
        if (untypedMaturity is not null)
            body.Maturity = untypedMaturity;
    }

    if (this.IsParameterBound(nameof(Pr)))
    {
        var untypedPr = UntypedValue.From(Pr);
        if (untypedPr is not null)
            body.Pr = untypedPr;
    }

    if (this.IsParameterBound(nameof(Redemption)))
    {
        var untypedRedemption = UntypedValue.From(Redemption);
        if (untypedRedemption is not null)
            body.Redemption = untypedRedemption;
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
                result = client.Drives[DriveId].Items[DriveItemId].Workbook.Functions.Disc.PostAsync(body, requestConfiguration =>
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
