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
    [GraphRoute("POST", "/drives/{drive-id}/items/{driveItem-id}/workbook/functions/binom_Dist")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDriveItemWorkbookFunctionBinom_Dist", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookFunctionResult))]
    public class InvokeMgDriveItemWorkbookFunctionBinom_DistCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DriveItemId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        public object? NumberS { get; set; }

        [Parameter(Mandatory = false)]
        public object? Trials { get; set; }

        [Parameter(Mandatory = false)]
        public object? ProbabilityS { get; set; }

        [Parameter(Mandatory = false)]
        public object? Cumulative { get; set; }





        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DriveItemId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Files.Client.Drives.Item.Items.Item.Workbook.Functions.Binom_Dist.Binom_DistPostRequestBody();

    if (this.IsParameterBound(nameof(NumberS)))
    {
        var untypedNumberS = UntypedValue.From(NumberS);
        if (untypedNumberS is not null)
            body.NumberS = untypedNumberS;
    }

    if (this.IsParameterBound(nameof(Trials)))
    {
        var untypedTrials = UntypedValue.From(Trials);
        if (untypedTrials is not null)
            body.Trials = untypedTrials;
    }

    if (this.IsParameterBound(nameof(ProbabilityS)))
    {
        var untypedProbabilityS = UntypedValue.From(ProbabilityS);
        if (untypedProbabilityS is not null)
            body.ProbabilityS = untypedProbabilityS;
    }

    if (this.IsParameterBound(nameof(Cumulative)))
    {
        var untypedCumulative = UntypedValue.From(Cumulative);
        if (untypedCumulative is not null)
            body.Cumulative = untypedCumulative;
    }

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookFunctionResult? result;
            try
            {
                result = client.Drives[DriveId].Items[DriveItemId].Workbook.Functions.Binom_Dist.PostAsync(body, requestConfiguration =>
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
