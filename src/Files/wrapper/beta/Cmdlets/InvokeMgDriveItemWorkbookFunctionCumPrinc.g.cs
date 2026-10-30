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
    [GraphRoute("POST", "/drives/{drive-id}/items/{driveItem-id}/workbook/functions/cumPrinc")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDriveItemWorkbookFunctionCumPrinc", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookFunctionResult))]
    public class InvokeMgDriveItemWorkbookFunctionCumPrincCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DriveItemId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        public object? Rate { get; set; }

        [Parameter(Mandatory = false)]
        public object? Nper { get; set; }

        [Parameter(Mandatory = false)]
        public object? Pv { get; set; }

        [Parameter(Mandatory = false)]
        public object? StartPeriod { get; set; }

        [Parameter(Mandatory = false)]
        public object? EndPeriod { get; set; }

        [Parameter(Mandatory = false)]
        public object? Type { get; set; }





        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DriveItemId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Files.Client.Drives.Item.Items.Item.Workbook.Functions.CumPrinc.CumPrincPostRequestBody();

    if (this.IsParameterBound(nameof(Rate)))
    {
        var untypedRate = UntypedValue.From(Rate);
        if (untypedRate is not null)
            body.Rate = untypedRate;
    }

    if (this.IsParameterBound(nameof(Nper)))
    {
        var untypedNper = UntypedValue.From(Nper);
        if (untypedNper is not null)
            body.Nper = untypedNper;
    }

    if (this.IsParameterBound(nameof(Pv)))
    {
        var untypedPv = UntypedValue.From(Pv);
        if (untypedPv is not null)
            body.Pv = untypedPv;
    }

    if (this.IsParameterBound(nameof(StartPeriod)))
    {
        var untypedStartPeriod = UntypedValue.From(StartPeriod);
        if (untypedStartPeriod is not null)
            body.StartPeriod = untypedStartPeriod;
    }

    if (this.IsParameterBound(nameof(EndPeriod)))
    {
        var untypedEndPeriod = UntypedValue.From(EndPeriod);
        if (untypedEndPeriod is not null)
            body.EndPeriod = untypedEndPeriod;
    }

    if (this.IsParameterBound(nameof(Type)))
    {
        var untypedType = UntypedValue.From(Type);
        if (untypedType is not null)
            body.Type = untypedType;
    }

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookFunctionResult? result;
            try
            {
                result = client.Drives[DriveId].Items[DriveItemId].Workbook.Functions.CumPrinc.PostAsync(body, requestConfiguration =>
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
