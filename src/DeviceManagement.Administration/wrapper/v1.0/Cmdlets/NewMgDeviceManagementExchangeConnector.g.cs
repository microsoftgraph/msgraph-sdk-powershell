#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client;
using Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement.Administration
{
    [GraphRoute("POST", "/deviceManagement/exchangeConnectors")]
    [Cmdlet(VerbsCommon.New, "MgDeviceManagementExchangeConnector", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.DeviceManagementExchangeConnector))]
    public class NewMgDeviceManagementExchangeConnectorCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? ConnectorServerName { get; set; }

        [Parameter(Mandatory = false)]
        public string? ExchangeAlias { get; set; }

        [Parameter(Mandatory = false)]
        public string? ExchangeOrganization { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastSyncDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? PrimarySmtpAddress { get; set; }

        [Parameter(Mandatory = false)]
        public string? ServerName { get; set; }

        [Parameter(Mandatory = false)]
        public string? Version { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.DeviceManagementExchangeConnectorType? ExchangeConnectorType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.DeviceManagementExchangeConnectorStatus? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.DeviceManagementExchangeConnector();

    if (this.IsParameterBound(nameof(ConnectorServerName)))
        body.ConnectorServerName = ConnectorServerName;

    if (this.IsParameterBound(nameof(ExchangeAlias)))
        body.ExchangeAlias = ExchangeAlias;

    if (this.IsParameterBound(nameof(ExchangeOrganization)))
        body.ExchangeOrganization = ExchangeOrganization;

    if (this.IsParameterBound(nameof(LastSyncDateTime)))
        body.LastSyncDateTime = LastSyncDateTime;

    if (this.IsParameterBound(nameof(PrimarySmtpAddress)))
        body.PrimarySmtpAddress = PrimarySmtpAddress;

    if (this.IsParameterBound(nameof(ServerName)))
        body.ServerName = ServerName;

    if (this.IsParameterBound(nameof(Version)))
        body.Version = Version;

    if (this.IsParameterBound(nameof(ExchangeConnectorType)))
        body.ExchangeConnectorType = ExchangeConnectorType;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.DeviceManagementExchangeConnector? result;
            try
            {
                result = client.DeviceManagement.ExchangeConnectors.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
