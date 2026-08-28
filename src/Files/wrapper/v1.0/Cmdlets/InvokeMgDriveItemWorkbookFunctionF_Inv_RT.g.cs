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
    [GraphRoute("POST", "/drives/{drive-id}/items/{driveItem-id}/workbook/functions/f_Inv_RT")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDriveItemWorkbookFunctionF_Inv_RT", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookFunctionResult))]
    public class InvokeMgDriveItemWorkbookFunctionF_Inv_RTCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DriveItemId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        public object? Probability { get; set; }

        [Parameter(Mandatory = false)]
        public object? DegFreedom1 { get; set; }

        [Parameter(Mandatory = false)]
        public object? DegFreedom2 { get; set; }





        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DriveItemId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Files.Client.Drives.Item.Items.Item.Workbook.Functions.F_Inv_RT.F_Inv_RTPostRequestBody();

    if (this.IsParameterBound(nameof(Probability)))
    {
        var untypedProbability = UntypedValue.From(Probability);
        if (untypedProbability is not null)
            body.Probability = untypedProbability;
    }

    if (this.IsParameterBound(nameof(DegFreedom1)))
    {
        var untypedDegFreedom1 = UntypedValue.From(DegFreedom1);
        if (untypedDegFreedom1 is not null)
            body.DegFreedom1 = untypedDegFreedom1;
    }

    if (this.IsParameterBound(nameof(DegFreedom2)))
    {
        var untypedDegFreedom2 = UntypedValue.From(DegFreedom2);
        if (untypedDegFreedom2 is not null)
            body.DegFreedom2 = untypedDegFreedom2;
    }

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookFunctionResult? result;
            try
            {
                result = client.Drives[DriveId].Items[DriveItemId].Workbook.Functions.F_Inv_RT.PostAsync(body, requestConfiguration =>
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
