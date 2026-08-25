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
    [GraphRoute("POST", "/print/shares/{printerShare-id}/jobs/{printJob-id}/cancel")]
    [Cmdlet(VerbsLifecycle.Stop, "MgPrintShareJob", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class StopMgPrintShareJobCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string PrinterShareId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string PrintJobId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PrintJobId, "Stop"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Print.Shares[PrinterShareId].Jobs[PrintJobId].Cancel.PostAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, PrintJobId);
                return;
            }

        }
    }
}
