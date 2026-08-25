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
    [GraphRoute("PATCH", "/servicePrincipals/{servicePrincipal-id}/remoteDesktopSecurityConfiguration")]
    [Cmdlet(VerbsData.Update, "MgServicePrincipalRemoteDesktopSecurityConfiguration", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Applications.Client.Models.RemoteDesktopSecurityConfiguration))]
    public class UpdateMgServicePrincipalRemoteDesktopSecurityConfigurationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ServicePrincipalId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? IsRemoteDesktopProtocolEnabled { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ServicePrincipalId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Applications.Client.Models.RemoteDesktopSecurityConfiguration();

    if (this.IsParameterBound(nameof(IsRemoteDesktopProtocolEnabled)))
        body.IsRemoteDesktopProtocolEnabled = IsRemoteDesktopProtocolEnabled;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Applications.Client.Models.RemoteDesktopSecurityConfiguration? result;
            try
            {
                result = client.ServicePrincipals[ServicePrincipalId].RemoteDesktopSecurityConfiguration.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, ServicePrincipalId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.ServicePrincipals[ServicePrincipalId].RemoteDesktopSecurityConfiguration.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, ServicePrincipalId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
