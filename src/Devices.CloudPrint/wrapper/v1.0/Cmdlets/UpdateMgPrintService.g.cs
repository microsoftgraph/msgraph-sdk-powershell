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
    [GraphRoute("PATCH", "/print/services/{printService-id}")]
    [Cmdlet(VerbsData.Update, "MgPrintService", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Models.PrintService))]
    public class UpdateMgPrintServiceCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string PrintServiceId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PrintServiceId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Models.PrintService();




        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Models.PrintService? result;
            try
            {
                result = client.Print.Services[PrintServiceId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, PrintServiceId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Print.Services[PrintServiceId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, PrintServiceId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
