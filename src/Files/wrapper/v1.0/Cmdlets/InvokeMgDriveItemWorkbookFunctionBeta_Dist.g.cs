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
    [GraphRoute("POST", "/drives/{drive-id}/items/{driveItem-id}/workbook/functions/beta_Dist")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDriveItemWorkbookFunctionBeta_Dist", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookFunctionResult))]
    public class InvokeMgDriveItemWorkbookFunctionBeta_DistCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DriveItemId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        public object? X { get; set; }

        [Parameter(Mandatory = false)]
        public object? Alpha { get; set; }

        [Parameter(Mandatory = false)]
        public object? Beta { get; set; }

        [Parameter(Mandatory = false)]
        public object? Cumulative { get; set; }

        [Parameter(Mandatory = false)]
        public object? A { get; set; }

        [Parameter(Mandatory = false)]
        public object? B { get; set; }





        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DriveItemId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Files.Client.Drives.Item.Items.Item.Workbook.Functions.Beta_Dist.Beta_DistPostRequestBody();

    if (this.IsParameterBound(nameof(X)))
    {
        var untypedX = UntypedValue.From(X);
        if (untypedX is not null)
            body.X = untypedX;
    }

    if (this.IsParameterBound(nameof(Alpha)))
    {
        var untypedAlpha = UntypedValue.From(Alpha);
        if (untypedAlpha is not null)
            body.Alpha = untypedAlpha;
    }

    if (this.IsParameterBound(nameof(Beta)))
    {
        var untypedBeta = UntypedValue.From(Beta);
        if (untypedBeta is not null)
            body.Beta = untypedBeta;
    }

    if (this.IsParameterBound(nameof(Cumulative)))
    {
        var untypedCumulative = UntypedValue.From(Cumulative);
        if (untypedCumulative is not null)
            body.Cumulative = untypedCumulative;
    }

    if (this.IsParameterBound(nameof(A)))
    {
        var untypedA = UntypedValue.From(A);
        if (untypedA is not null)
            body.A = untypedA;
    }

    if (this.IsParameterBound(nameof(B)))
    {
        var untypedB = UntypedValue.From(B);
        if (untypedB is not null)
            body.B = untypedB;
    }

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookFunctionResult? result;
            try
            {
                result = client.Drives[DriveId].Items[DriveItemId].Workbook.Functions.Beta_Dist.PostAsync(body, requestConfiguration =>
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
