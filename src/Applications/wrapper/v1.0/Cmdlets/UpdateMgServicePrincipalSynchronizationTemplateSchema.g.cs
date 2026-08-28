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
    [GraphRoute("PATCH", "/servicePrincipals/{servicePrincipal-id}/synchronization/templates/{synchronizationTemplate-id}/schema")]
    [Cmdlet(VerbsData.Update, "MgServicePrincipalSynchronizationTemplateSchema", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Applications.Client.Models.SynchronizationSchema))]
    public class UpdateMgServicePrincipalSynchronizationTemplateSchemaCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ServicePrincipalId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SynchronizationTemplateId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Version { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.SynchronizationRule[]? SynchronizationRules { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SynchronizationTemplateId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Applications.Client.Models.SynchronizationSchema();

    if (this.IsParameterBound(nameof(Version)))
        body.Version = Version;

    if (this.IsParameterBound(nameof(SynchronizationRules)))
        body.SynchronizationRules = SynchronizationRules!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Applications.Client.Models.SynchronizationSchema? result;
            try
            {
                result = client.ServicePrincipals[ServicePrincipalId].Synchronization.Templates[SynchronizationTemplateId].Schema.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, SynchronizationTemplateId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.ServicePrincipals[ServicePrincipalId].Synchronization.Templates[SynchronizationTemplateId].Schema.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, SynchronizationTemplateId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
