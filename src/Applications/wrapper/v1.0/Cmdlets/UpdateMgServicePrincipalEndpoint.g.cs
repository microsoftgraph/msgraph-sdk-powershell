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
    [GraphRoute("PATCH", "/servicePrincipals/{servicePrincipal-id}/endpoints/{endpoint-id}")]
    [Cmdlet(VerbsData.Update, "MgServicePrincipalEndpoint", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Applications.Client.Models.Endpoint))]
    public class UpdateMgServicePrincipalEndpointCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ServicePrincipalId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string EndpointId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? DeletedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Capability { get; set; }

        [Parameter(Mandatory = false)]
        public string? ProviderId { get; set; }

        [Parameter(Mandatory = false)]
        public string? ProviderName { get; set; }

        [Parameter(Mandatory = false)]
        public string? ProviderResourceId { get; set; }

        [Parameter(Mandatory = false)]
        public string? Uri { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(EndpointId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Applications.Client.Models.Endpoint();

    if (this.IsParameterBound(nameof(DeletedDateTime)))
        body.DeletedDateTime = DeletedDateTime;

    if (this.IsParameterBound(nameof(Capability)))
        body.Capability = Capability;

    if (this.IsParameterBound(nameof(ProviderId)))
        body.ProviderId = ProviderId;

    if (this.IsParameterBound(nameof(ProviderName)))
        body.ProviderName = ProviderName;

    if (this.IsParameterBound(nameof(ProviderResourceId)))
        body.ProviderResourceId = ProviderResourceId;

    if (this.IsParameterBound(nameof(Uri)))
        body.Uri = Uri;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Applications.Client.Models.Endpoint? result;
            try
            {
                result = client.ServicePrincipals[ServicePrincipalId].Endpoints[EndpointId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, EndpointId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.ServicePrincipals[ServicePrincipalId].Endpoints[EndpointId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, EndpointId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
