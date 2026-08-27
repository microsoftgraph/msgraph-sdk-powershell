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
    [GraphRoute("POST", "/drives/{drive-id}/items/{driveItem-id}/workbook/functions/percentRank_Exc")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDriveItemWorkbookFunctionPercentRank_Exc", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookFunctionResult))]
    public class InvokeMgDriveItemWorkbookFunctionPercentRank_ExcCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DriveItemId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        public object? Array { get; set; }

        [Parameter(Mandatory = false)]
        public object? X { get; set; }

        [Parameter(Mandatory = false)]
        public object? Significance { get; set; }





        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DriveItemId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Files.Client.Drives.Item.Items.Item.Workbook.Functions.PercentRank_Exc.PercentRank_ExcPostRequestBody();

    if (this.IsParameterBound(nameof(Array)))
    {
        var untypedArray = UntypedValue.From(Array);
        if (untypedArray is not null)
            body.Array = untypedArray;
    }

    if (this.IsParameterBound(nameof(X)))
    {
        var untypedX = UntypedValue.From(X);
        if (untypedX is not null)
            body.X = untypedX;
    }

    if (this.IsParameterBound(nameof(Significance)))
    {
        var untypedSignificance = UntypedValue.From(Significance);
        if (untypedSignificance is not null)
            body.Significance = untypedSignificance;
    }

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookFunctionResult? result;
            try
            {
                result = client.Drives[DriveId].Items[DriveItemId].Workbook.Functions.PercentRank_Exc.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, DriveItemId);
                return;
            }

            WriteObject(result);
        }
    }
}
