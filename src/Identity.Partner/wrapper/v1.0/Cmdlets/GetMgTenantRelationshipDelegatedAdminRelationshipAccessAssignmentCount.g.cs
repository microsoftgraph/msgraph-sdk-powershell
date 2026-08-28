#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.Partner.Client;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.Partner
{
    [GraphRoute("GET", "/tenantRelationships/delegatedAdminRelationships/{delegatedAdminRelationship-id}/accessAssignments/$count")]
    [Cmdlet(VerbsCommon.Get, "MgTenantRelationshipDelegatedAdminRelationshipAccessAssignmentCount")]
    [OutputType(typeof(int))]
    public class GetMgTenantRelationshipDelegatedAdminRelationshipAccessAssignmentCountCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DelegatedAdminRelationshipId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        public string? Filter { get; set; }

        [Parameter(Mandatory = false)]
        public string? Search { get; set; }



        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            int? result;
            try
            {
                result = client.TenantRelationships.DelegatedAdminRelationships[DelegatedAdminRelationshipId].AccessAssignments.Count.GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Filter)))
                        requestConfiguration.QueryParameters.Filter = Filter;

                    if (this.IsParameterBound(nameof(Search)))
                        requestConfiguration.QueryParameters.Search = Search;

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, DelegatedAdminRelationshipId);
                return;
            }

            if (result is not null)
                WriteObject(result);
        }
    }
}
