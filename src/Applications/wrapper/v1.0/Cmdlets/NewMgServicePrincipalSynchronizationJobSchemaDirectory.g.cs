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
    [GraphRoute("POST", "/servicePrincipals/{servicePrincipal-id}/synchronization/jobs/{synchronizationJob-id}/schema/directories")]
    [Cmdlet(VerbsCommon.New, "MgServicePrincipalSynchronizationJobSchemaDirectory", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Applications.Client.Models.DirectoryDefinition))]
    public class NewMgServicePrincipalSynchronizationJobSchemaDirectoryCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ServicePrincipalId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SynchronizationJobId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? DiscoveryDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Name { get; set; }

        [Parameter(Mandatory = false)]
        public bool? ReadOnly { get; set; }

        [Parameter(Mandatory = false)]
        public string? Version { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.DirectoryDefinitionDiscoverabilities? Discoverabilities { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.ObjectDefinition[]? Objects { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SynchronizationJobId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Applications.Client.Models.DirectoryDefinition();

    if (this.IsParameterBound(nameof(DiscoveryDateTime)))
        body.DiscoveryDateTime = DiscoveryDateTime;

    if (this.IsParameterBound(nameof(Name)))
        body.Name = Name;

    if (this.IsParameterBound(nameof(ReadOnly)))
        body.ReadOnly = ReadOnly;

    if (this.IsParameterBound(nameof(Version)))
        body.Version = Version;

    if (this.IsParameterBound(nameof(Discoverabilities)))
        body.Discoverabilities = Discoverabilities;

    if (this.IsParameterBound(nameof(Objects)))
        body.Objects = Objects!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Applications.Client.Models.DirectoryDefinition? result;
            try
            {
                result = client.ServicePrincipals[ServicePrincipalId].Synchronization.Jobs[SynchronizationJobId].Schema.Directories.PostAsync(body, requestConfiguration =>
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
