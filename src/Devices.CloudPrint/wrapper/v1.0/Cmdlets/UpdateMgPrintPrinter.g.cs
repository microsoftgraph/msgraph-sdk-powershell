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
    [GraphRoute("PATCH", "/print/printers/{printer-id}")]
    [Cmdlet(VerbsData.Update, "MgPrintPrinter", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Models.Printer))]
    public class UpdateMgPrintPrinterCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string PrinterId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsAcceptingJobs { get; set; }

        [Parameter(Mandatory = false)]
        public string? Manufacturer { get; set; }

        [Parameter(Mandatory = false)]
        public string? Model { get; set; }

        [Parameter(Mandatory = false)]
        public bool? HasPhysicalDevice { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsShared { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastSeenDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? RegisteredDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Models.PrinterCapabilities? Capabilities { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Models.PrinterDefaults? Defaults { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Models.PrinterLocation? Location { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Models.PrinterStatus? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PrinterId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Models.Printer();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(IsAcceptingJobs)))
        body.IsAcceptingJobs = IsAcceptingJobs;

    if (this.IsParameterBound(nameof(Manufacturer)))
        body.Manufacturer = Manufacturer;

    if (this.IsParameterBound(nameof(Model)))
        body.Model = Model;

    if (this.IsParameterBound(nameof(HasPhysicalDevice)))
        body.HasPhysicalDevice = HasPhysicalDevice;

    if (this.IsParameterBound(nameof(IsShared)))
        body.IsShared = IsShared;

    if (this.IsParameterBound(nameof(LastSeenDateTime)))
        body.LastSeenDateTime = LastSeenDateTime;

    if (this.IsParameterBound(nameof(RegisteredDateTime)))
        body.RegisteredDateTime = RegisteredDateTime;

    if (this.IsParameterBound(nameof(Capabilities)))
        body.Capabilities = Capabilities;

    if (this.IsParameterBound(nameof(Defaults)))
        body.Defaults = Defaults;

    if (this.IsParameterBound(nameof(Location)))
        body.Location = Location;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Models.Printer? result;
            try
            {
                result = client.Print.Printers[PrinterId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, PrinterId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Print.Printers[PrinterId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, PrinterId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
