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
    [GraphRoute("POST", "/drives/{drive-id}/items/{driveItem-id}/workbook/functions/seriesSum")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDriveItemWorkbookFunctionSeriesSum", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookFunctionResult))]
    public class InvokeMgDriveItemWorkbookFunctionSeriesSumCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DriveItemId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        public object? X { get; set; }

        [Parameter(Mandatory = false)]
        public object? N { get; set; }

        [Parameter(Mandatory = false)]
        public object? M { get; set; }

        [Parameter(Mandatory = false)]
        public object? Coefficients { get; set; }





        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DriveItemId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Files.Client.Drives.Item.Items.Item.Workbook.Functions.SeriesSum.SeriesSumPostRequestBody();

    if (this.IsParameterBound(nameof(X)))
    {
        var untypedX = UntypedValue.From(X);
        if (untypedX is not null)
            body.X = untypedX;
    }

    if (this.IsParameterBound(nameof(N)))
    {
        var untypedN = UntypedValue.From(N);
        if (untypedN is not null)
            body.N = untypedN;
    }

    if (this.IsParameterBound(nameof(M)))
    {
        var untypedM = UntypedValue.From(M);
        if (untypedM is not null)
            body.M = untypedM;
    }

    if (this.IsParameterBound(nameof(Coefficients)))
    {
        var untypedCoefficients = UntypedValue.From(Coefficients);
        if (untypedCoefficients is not null)
            body.Coefficients = untypedCoefficients;
    }

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookFunctionResult? result;
            try
            {
                result = client.Drives[DriveId].Items[DriveItemId].Workbook.Functions.SeriesSum.PostAsync(body, requestConfiguration =>
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
