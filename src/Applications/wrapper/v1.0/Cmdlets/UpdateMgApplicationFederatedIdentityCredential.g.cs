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
    [GraphRoute("PATCH", "/applications/{application-id}/federatedIdentityCredentials/{federatedIdentityCredential-id}")]
    [Cmdlet(VerbsData.Update, "MgApplicationFederatedIdentityCredential", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Applications.Client.Models.FederatedIdentityCredential))]
    public class UpdateMgApplicationFederatedIdentityCredentialCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ApplicationId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string FederatedIdentityCredentialId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string[]? Audiences { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? Issuer { get; set; }

        [Parameter(Mandatory = false)]
        public string? Name { get; set; }

        [Parameter(Mandatory = false)]
        public string? Subject { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(FederatedIdentityCredentialId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Applications.Client.Models.FederatedIdentityCredential();

    if (this.IsParameterBound(nameof(Audiences)))
        body.Audiences = Audiences!.ToList();

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(Issuer)))
        body.Issuer = Issuer;

    if (this.IsParameterBound(nameof(Name)))
        body.Name = Name;

    if (this.IsParameterBound(nameof(Subject)))
        body.Subject = Subject;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Applications.Client.Models.FederatedIdentityCredential? result;
            try
            {
                result = client.Applications[ApplicationId].FederatedIdentityCredentials[FederatedIdentityCredentialId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, FederatedIdentityCredentialId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Applications[ApplicationId].FederatedIdentityCredentials[FederatedIdentityCredentialId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, FederatedIdentityCredentialId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
