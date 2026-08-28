#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Devices.CloudPrint.Client;
using Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Devices.CloudPrint
{
    [GraphRoute("POST", "/print/shares/{printerShare-id}/jobs/{printJob-id}/documents/{printDocument-id}/createUploadSession")]
    [Cmdlet(VerbsCommon.New, "MgPrintShareJobDocumentUploadSession", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Models.UploadSession))]
    public class NewMgPrintShareJobDocumentUploadSessionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string PrinterShareId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string PrintJobId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string PrintDocumentId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Models.PrintDocumentUploadProperties? Properties { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PrintDocumentId, "New"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Print.Shares.Item.Jobs.Item.Documents.Item.CreateUploadSession.CreateUploadSessionPostRequestBody();

    if (this.IsParameterBound(nameof(Properties)))
        body.Properties = Properties;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Models.UploadSession? result;
            try
            {
                result = client.Print.Shares[PrinterShareId].Jobs[PrintJobId].Documents[PrintDocumentId].CreateUploadSession.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, PrintDocumentId);
                return;
            }

            WriteObject(result);
        }
    }
}
