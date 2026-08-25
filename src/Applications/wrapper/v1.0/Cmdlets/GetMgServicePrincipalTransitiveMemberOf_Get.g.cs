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
    [GraphRoute("GET", "/servicePrincipals/{servicePrincipal-id}/transitiveMemberOf/{directoryObject-id}")]
    [Cmdlet(VerbsCommon.Get, "MgServicePrincipalTransitiveMemberOf_Get")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Applications.Client.Models.DirectoryObject))]
    public class GetMgServicePrincipalTransitiveMemberOf_GetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ServicePrincipalId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DirectoryObjectId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        [Alias("Select")]
        public string[]? Property { get; set; }
        [Parameter(Mandatory = false)]
        [Alias("Expand")]
        public string[]? ExpandProperty { get; set; }


        [Parameter(Mandatory = false,
            HelpMessage = "Sets the 'ConsistencyLevel' request header (for example an ETag for optimistic concurrency; some Graph APIs require it even where the spec marks it optional).")]
        public string? ConsistencyLevel { get; set; }


        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Applications.Client.Models.DirectoryObject? result;
            try
            {
                result = client.ServicePrincipals[ServicePrincipalId].TransitiveMemberOf[DirectoryObjectId].GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;


        if (this.IsParameterBound(nameof(ConsistencyLevel)))
            requestConfiguration.Headers.Add("ConsistencyLevel", ConsistencyLevel!);


        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, DirectoryObjectId);
                return;
            }

            WriteObject(result);
        }
    }
}
