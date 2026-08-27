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
    [GraphRoute("PATCH", "/print/services/{printService-id}/endpoints/{printServiceEndpoint-id}")]
    [Cmdlet(VerbsData.Update, "MgPrintServiceEndpoint", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Models.PrintServiceEndpoint))]
    public class UpdateMgPrintServiceEndpointCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string PrintServiceId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string PrintServiceEndpointId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? Uri { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PrintServiceEndpointId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Models.PrintServiceEndpoint();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(Uri)))
        body.Uri = Uri;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Models.PrintServiceEndpoint? result;
            try
            {
                result = client.Print.Services[PrintServiceId].Endpoints[PrintServiceEndpointId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, PrintServiceEndpointId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Print.Services[PrintServiceId].Endpoints[PrintServiceEndpointId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, PrintServiceEndpointId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
