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
    [GraphRoute("PATCH", "/print/printers/{printer-id}/taskTriggers/{printTaskTrigger-id}")]
    [Cmdlet(VerbsData.Update, "MgPrintPrinterTaskTrigger", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Models.PrintTaskTrigger))]
    public class UpdateMgPrintPrinterTaskTriggerCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string PrinterId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string PrintTaskTriggerId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Models.PrintEvent? Event { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Models.PrintTaskDefinition? Definition { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PrintTaskTriggerId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Models.PrintTaskTrigger();


    if (this.IsParameterBound(nameof(Event)))
        body.Event = Event;

    if (this.IsParameterBound(nameof(Definition)))
        body.Definition = Definition;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Models.PrintTaskTrigger? result;
            try
            {
                result = client.Print.Printers[PrinterId].TaskTriggers[PrintTaskTriggerId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, PrintTaskTriggerId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Print.Printers[PrinterId].TaskTriggers[PrintTaskTriggerId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, PrintTaskTriggerId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
