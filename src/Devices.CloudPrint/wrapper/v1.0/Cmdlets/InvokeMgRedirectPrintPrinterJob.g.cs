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
    [GraphRoute("POST", "/print/printers/{printer-id}/jobs/{printJob-id}/redirect")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgRedirectPrintPrinterJob", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Models.PrintJob))]
    public class InvokeMgRedirectPrintPrinterJobCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string PrinterId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string PrintJobId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DestinationPrinterId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Models.PrintJobConfiguration? Configuration { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PrintJobId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Print.Printers.Item.Jobs.Item.Redirect.RedirectPostRequestBody();

    if (this.IsParameterBound(nameof(DestinationPrinterId)))
        body.DestinationPrinterId = DestinationPrinterId;
    if (this.IsParameterBound(nameof(Configuration)))
        body.Configuration = Configuration;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Models.PrintJob? result;
            try
            {
                result = client.Print.Printers[PrinterId].Jobs[PrintJobId].Redirect.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, PrintJobId);
                return;
            }

            WriteObject(result);
        }
    }
}
