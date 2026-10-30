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
    [GraphRoute("POST", "/drives/{drive-id}/items/{driveItem-id}/workbook/functions/substitute")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDriveItemWorkbookFunctionSubstitute", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookFunctionResult))]
    public class InvokeMgDriveItemWorkbookFunctionSubstituteCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DriveItemId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        public object? Text { get; set; }

        [Parameter(Mandatory = false)]
        public object? OldText { get; set; }

        [Parameter(Mandatory = false)]
        public object? NewText { get; set; }

        [Parameter(Mandatory = false)]
        public object? InstanceNum { get; set; }





        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DriveItemId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Files.Client.Drives.Item.Items.Item.Workbook.Functions.Substitute.SubstitutePostRequestBody();

    if (this.IsParameterBound(nameof(Text)))
    {
        var untypedText = UntypedValue.From(Text);
        if (untypedText is not null)
            body.Text = untypedText;
    }

    if (this.IsParameterBound(nameof(OldText)))
    {
        var untypedOldText = UntypedValue.From(OldText);
        if (untypedOldText is not null)
            body.OldText = untypedOldText;
    }

    if (this.IsParameterBound(nameof(NewText)))
    {
        var untypedNewText = UntypedValue.From(NewText);
        if (untypedNewText is not null)
            body.NewText = untypedNewText;
    }

    if (this.IsParameterBound(nameof(InstanceNum)))
    {
        var untypedInstanceNum = UntypedValue.From(InstanceNum);
        if (untypedInstanceNum is not null)
            body.InstanceNum = untypedInstanceNum;
    }

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookFunctionResult? result;
            try
            {
                result = client.Drives[DriveId].Items[DriveItemId].Workbook.Functions.Substitute.PostAsync(body, requestConfiguration =>
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
