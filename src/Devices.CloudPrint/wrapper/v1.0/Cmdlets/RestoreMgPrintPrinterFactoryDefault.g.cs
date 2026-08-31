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
    [GraphRoute("POST", "/print/printers/{printer-id}/restoreFactoryDefaults")]
    [Cmdlet(VerbsData.Restore, "MgPrintPrinterFactoryDefault", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class RestoreMgPrintPrinterFactoryDefaultCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string PrinterId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PrinterId, "Restore"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Print.Printers[PrinterId].RestoreFactoryDefaults.PostAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, PrinterId);
                return;
            }

        }
    }
}
