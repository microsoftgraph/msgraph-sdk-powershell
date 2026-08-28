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
    [GraphRoute("POST", "/drives/{drive-id}/items/{driveItem-id}/workbook/functions/gamma_Inv")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDriveItemWorkbookFunctionGamma_Inv", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookFunctionResult))]
    public class InvokeMgDriveItemWorkbookFunctionGamma_InvCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DriveItemId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        public object? Probability { get; set; }

        [Parameter(Mandatory = false)]
        public object? Alpha { get; set; }

        [Parameter(Mandatory = false)]
        public object? Beta { get; set; }





        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DriveItemId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Files.Client.Drives.Item.Items.Item.Workbook.Functions.Gamma_Inv.Gamma_InvPostRequestBody();

    if (this.IsParameterBound(nameof(Probability)))
    {
        var untypedProbability = UntypedValue.From(Probability);
        if (untypedProbability is not null)
            body.Probability = untypedProbability;
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

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookFunctionResult? result;
            try
            {
                result = client.Drives[DriveId].Items[DriveItemId].Workbook.Functions.Gamma_Inv.PostAsync(body, requestConfiguration =>
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
