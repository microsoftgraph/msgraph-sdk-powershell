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
    [GraphRoute("PATCH", "/applications/{application-id}/synchronization/templates/{synchronizationTemplate-id}/schema/directories/{directoryDefinition-id}")]
    [Cmdlet(VerbsData.Update, "MgApplicationSynchronizationTemplateSchemaDirectory", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Applications.Client.Models.DirectoryDefinition))]
    public class UpdateMgApplicationSynchronizationTemplateSchemaDirectoryCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ApplicationId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SynchronizationTemplateId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string DirectoryDefinitionId { get; set; } = string.Empty;

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
            if (!ShouldProcess(DirectoryDefinitionId, "Update"))
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
                result = client.Applications[ApplicationId].Synchronization.Templates[SynchronizationTemplateId].Schema.Directories[DirectoryDefinitionId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, DirectoryDefinitionId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Applications[ApplicationId].Synchronization.Templates[SynchronizationTemplateId].Schema.Directories[DirectoryDefinitionId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, DirectoryDefinitionId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
