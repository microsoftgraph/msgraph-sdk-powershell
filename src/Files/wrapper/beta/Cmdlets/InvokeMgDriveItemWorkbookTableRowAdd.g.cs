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
    [GraphRoute("POST", "/drives/{drive-id}/items/{driveItem-id}/workbook/tables/{workbookTable-id}/rows/add")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDriveItemWorkbookTableRowAdd", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookTableRow))]
    public class InvokeMgDriveItemWorkbookTableRowAddCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DriveItemId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string WorkbookTableId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public int? Index { get; set; }


        [Parameter(Mandatory = false)]
        public object? Values { get; set; }





        protected override void ProcessRecord()
        {
            if (!ShouldProcess(WorkbookTableId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Files.Client.Drives.Item.Items.Item.Workbook.Tables.Item.Rows.Add.AddPostRequestBody();

    if (this.IsParameterBound(nameof(Index)))
        body.Index = Index;
    if (this.IsParameterBound(nameof(Values)))
    {
        var untypedValues = UntypedValue.From(Values);
        if (untypedValues is not null)
            body.Values = untypedValues;
    }

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookTableRow? result;
            try
            {
                result = client.Drives[DriveId].Items[DriveItemId].Workbook.Tables[WorkbookTableId].Rows.Add.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, WorkbookTableId);
                return;
            }

            WriteObject(result);
        }
    }
}
