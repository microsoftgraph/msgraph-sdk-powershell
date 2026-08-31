#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Devices.CloudPrint.Client;
using Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Devices.CloudPrint
{
    [GraphRoute("PATCH", "/print/printers/{printer-id}/jobs/{printJob-id}/documents/{printDocument-id}")]
    [Cmdlet(VerbsData.Update, "MgPrintPrinterJobDocument", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Models.PrintDocument))]
    public class UpdateMgPrintPrinterJobDocumentCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string PrinterId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string PrintJobId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string PrintDocumentId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? ContentType { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? DownloadedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public long? Size { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? UploadedDateTime { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PrintDocumentId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Models.PrintDocument();

    if (this.IsParameterBound(nameof(ContentType)))
        body.ContentType = ContentType;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(DownloadedDateTime)))
        body.DownloadedDateTime = DownloadedDateTime;

    if (this.IsParameterBound(nameof(Size)))
        body.Size = Size;

    if (this.IsParameterBound(nameof(UploadedDateTime)))
        body.UploadedDateTime = UploadedDateTime;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Models.PrintDocument? result;
            try
            {
                result = client.Print.Printers[PrinterId].Jobs[PrintJobId].Documents[PrintDocumentId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, PrintDocumentId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Print.Printers[PrinterId].Jobs[PrintJobId].Documents[PrintDocumentId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, PrintDocumentId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
