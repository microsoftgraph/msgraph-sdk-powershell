#nullable enable

using System;
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
    [GraphRoute("GET", "/servicePrincipals/{servicePrincipal-id}/synchronization/jobs/{synchronizationJob-id}/schema/directories/{directoryDefinition-id}")]
    [Cmdlet(VerbsCommon.Get, "MgServicePrincipalSynchronizationJobSchemaDirectory_Get")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Applications.Client.Models.DirectoryDefinition))]
    public class GetMgServicePrincipalSynchronizationJobSchemaDirectory_GetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ServicePrincipalId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SynchronizationJobId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string DirectoryDefinitionId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        [Alias("Select")]
        public string[]? Property { get; set; }
        [Parameter(Mandatory = false)]
        [Alias("Expand")]
        public string[]? ExpandProperty { get; set; }



        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Applications.Client.Models.DirectoryDefinition? result;
            try
            {
                result = client.ServicePrincipals[ServicePrincipalId].Synchronization.Jobs[SynchronizationJobId].Schema.Directories[DirectoryDefinitionId].GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;



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
