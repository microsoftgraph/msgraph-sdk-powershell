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
    [GraphRoute("POST", "/print/shares/{printerShare-id}/jobs/{printJob-id}/abort")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgAbortPrintShareJob", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgAbortPrintShareJobCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string PrinterShareId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string PrintJobId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Reason { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PrintJobId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Print.Shares.Item.Jobs.Item.Abort.AbortPostRequestBody();

    if (this.IsParameterBound(nameof(Reason)))
        body.Reason = Reason;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Print.Shares[PrinterShareId].Jobs[PrintJobId].Abort.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, PrintJobId);
                return;
            }

        }
    }
}
