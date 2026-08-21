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
    [GraphRoute("POST", "/drives/{drive-id}/items/{driveItem-id}/workbook/functions/rank_Eq")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDriveItemWorkbookFunctionRank_Eq", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookFunctionResult))]
    public class InvokeMgDriveItemWorkbookFunctionRank_EqCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DriveItemId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        public object? Number { get; set; }

        [Parameter(Mandatory = false)]
        public object? Ref { get; set; }

        [Parameter(Mandatory = false)]
        public object? Order { get; set; }





        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DriveItemId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Files.Client.Drives.Item.Items.Item.Workbook.Functions.Rank_Eq.Rank_EqPostRequestBody();

    if (this.IsParameterBound(nameof(Number)))
    {
        var untypedNumber = UntypedValue.From(Number);
        if (untypedNumber is not null)
            body.Number = untypedNumber;
    }

    if (this.IsParameterBound(nameof(Ref)))
    {
        var untypedRef = UntypedValue.From(Ref);
        if (untypedRef is not null)
            body.Ref = untypedRef;
    }

    if (this.IsParameterBound(nameof(Order)))
    {
        var untypedOrder = UntypedValue.From(Order);
        if (untypedOrder is not null)
            body.Order = untypedOrder;
    }

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookFunctionResult? result;
            try
            {
                result = client.Drives[DriveId].Items[DriveItemId].Workbook.Functions.Rank_Eq.PostAsync(body, requestConfiguration =>
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
