#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Groups.Client;
using Microsoft.Graph.PowerShell.Groups.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Groups
{
    [GraphRoute("GET", "/groups/{group-id}/membersWithLicenseErrors/{directoryObject-id}/graph.servicePrincipal")]
    [Cmdlet(VerbsCommon.Get, "MgGroupMemberWithLicenseErrorAsServicePrincipal_Get")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Groups.Client.Models.ServicePrincipal))]
    public class GetMgGroupMemberWithLicenseErrorAsServicePrincipal_GetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
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

            Microsoft.Graph.PowerShell.Groups.Client.Models.ServicePrincipal? result;
            try
            {
                result = client.Groups[GroupId].MembersWithLicenseErrors[DirectoryObjectId].GraphServicePrincipal.GetAsync(requestConfiguration =>
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
