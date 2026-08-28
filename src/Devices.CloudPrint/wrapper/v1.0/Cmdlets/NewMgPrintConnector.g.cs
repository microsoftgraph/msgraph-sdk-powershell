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
    [GraphRoute("POST", "/print/connectors")]
    [Cmdlet(VerbsCommon.New, "MgPrintConnector", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Models.PrintConnector))]
    public class NewMgPrintConnectorCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? AppVersion { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? FullyQualifiedDomainName { get; set; }

        [Parameter(Mandatory = false)]
        public string? OperatingSystem { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? RegisteredDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Models.PrinterLocation? Location { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Models.PrintConnector();

    if (this.IsParameterBound(nameof(AppVersion)))
        body.AppVersion = AppVersion;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(FullyQualifiedDomainName)))
        body.FullyQualifiedDomainName = FullyQualifiedDomainName;

    if (this.IsParameterBound(nameof(OperatingSystem)))
        body.OperatingSystem = OperatingSystem;

    if (this.IsParameterBound(nameof(RegisteredDateTime)))
        body.RegisteredDateTime = RegisteredDateTime;

    if (this.IsParameterBound(nameof(Location)))
        body.Location = Location;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.CloudPrint.Client.Models.PrintConnector? result;
            try
            {
                result = client.Print.Connectors.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
