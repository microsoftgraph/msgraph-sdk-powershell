#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Applications.Client;
using Microsoft.Graph.PowerShell.Applications.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Applications
{
    [GraphRoute("POST", "/applications/{application-id}/synchronization/templates/{synchronizationTemplate-id}/schema/directories/{directoryDefinition-id}/discover")]
    [Cmdlet(VerbsCommon.Find, "MgApplicationSynchronizationTemplateSchemaDirectory", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Applications.Client.Models.DirectoryDefinition))]
    public class FindMgApplicationSynchronizationTemplateSchemaDirectoryCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ApplicationId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SynchronizationTemplateId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string DirectoryDefinitionId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DirectoryDefinitionId, "Find"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Applications.Client.Models.DirectoryDefinition? result;
            try
            {
                result = client.Applications[ApplicationId].Synchronization.Templates[SynchronizationTemplateId].Schema.Directories[DirectoryDefinitionId].Discover.PostAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, DirectoryDefinitionId);
                return;
            }

            WriteObject(result);
        }
    }
}
