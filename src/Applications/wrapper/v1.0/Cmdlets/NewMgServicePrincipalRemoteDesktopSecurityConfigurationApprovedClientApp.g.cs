#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Applications.Client;
using Microsoft.Graph.PowerShell.Applications.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Applications
{
    [GraphRoute("POST", "/servicePrincipals/{servicePrincipal-id}/remoteDesktopSecurityConfiguration/approvedClientApps")]
    [Cmdlet(VerbsCommon.New, "MgServicePrincipalRemoteDesktopSecurityConfigurationApprovedClientApp", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Applications.Client.Models.ApprovedClientApp))]
    public class NewMgServicePrincipalRemoteDesktopSecurityConfigurationApprovedClientAppCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ServicePrincipalId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ServicePrincipalId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Applications.Client.Models.ApprovedClientApp();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Applications.Client.Models.ApprovedClientApp? result;
            try
            {
                result = client.ServicePrincipals[ServicePrincipalId].RemoteDesktopSecurityConfiguration.ApprovedClientApps.PostAsync(body, requestConfiguration =>
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
