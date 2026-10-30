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
    [GraphRoute("POST", "/drives/{drive-id}/items/{driveItem-id}/workbook/functions/findB")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDriveItemWorkbookFunctionFindB", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookFunctionResult))]
    public class InvokeMgDriveItemWorkbookFunctionFindBCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DriveItemId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        public object? FindText { get; set; }

        [Parameter(Mandatory = false)]
        public object? WithinText { get; set; }

        [Parameter(Mandatory = false)]
        public object? StartNum { get; set; }





        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DriveItemId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Files.Client.Drives.Item.Items.Item.Workbook.Functions.FindB.FindBPostRequestBody();

    if (this.IsParameterBound(nameof(FindText)))
    {
        var untypedFindText = UntypedValue.From(FindText);
        if (untypedFindText is not null)
            body.FindText = untypedFindText;
    }

    if (this.IsParameterBound(nameof(WithinText)))
    {
        var untypedWithinText = UntypedValue.From(WithinText);
        if (untypedWithinText is not null)
            body.WithinText = untypedWithinText;
    }

    if (this.IsParameterBound(nameof(StartNum)))
    {
        var untypedStartNum = UntypedValue.From(StartNum);
        if (untypedStartNum is not null)
            body.StartNum = untypedStartNum;
    }

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookFunctionResult? result;
            try
            {
                result = client.Drives[DriveId].Items[DriveItemId].Workbook.Functions.FindB.PostAsync(body, requestConfiguration =>
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
