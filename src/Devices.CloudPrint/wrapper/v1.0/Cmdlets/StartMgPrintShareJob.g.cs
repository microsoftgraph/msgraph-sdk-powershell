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
    [GraphRoute("POST", "/print/shares/{printerShare-id}/jobs/{printJob-id}/start")]
    [Cmdlet(VerbsLifecycle.Start, "MgPrintShareJob", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Models.PrintJobStatus))]
    public class StartMgPrintShareJobCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string PrinterShareId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string PrintJobId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PrintJobId, "Start"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Models.PrintJobStatus? result;
            try
            {
                result = client.Print.Shares[PrinterShareId].Jobs[PrintJobId].Start.PostAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, PrintJobId);
                return;
            }

            WriteObject(result);
        }
    }
}
