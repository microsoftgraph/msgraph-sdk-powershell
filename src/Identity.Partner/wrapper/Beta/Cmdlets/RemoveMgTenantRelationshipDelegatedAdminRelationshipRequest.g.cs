#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.Partner.Client;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.Partner
{
    [GraphRoute("DELETE", "/tenantRelationships/delegatedAdminRelationships/{delegatedAdminRelationship-id}/requests/{delegatedAdminRelationshipRequest-id}")]
    [Cmdlet(VerbsCommon.Remove, "MgTenantRelationshipDelegatedAdminRelationshipRequest", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.High)]
    public class RemoveMgTenantRelationshipDelegatedAdminRelationshipRequestCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DelegatedAdminRelationshipId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DelegatedAdminRelationshipRequestId { get; set; } = string.Empty;


        [Parameter(Mandatory = false,
            HelpMessage = "Sets the 'If-Match' request header (for example an ETag for optimistic concurrency; some Graph APIs require it even where the spec marks it optional).")]
        public string? IfMatch { get; set; }




        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DelegatedAdminRelationshipRequestId, "Remove"))
                return;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            // DeleteAsync returns a plain Task: a standard delete response has no body.
            try
            {
                client.TenantRelationships.DelegatedAdminRelationships[DelegatedAdminRelationshipId].Requests[DelegatedAdminRelationshipRequestId].DeleteAsync(requestConfiguration =>
                {

                        if (this.IsParameterBound(nameof(IfMatch)))
                            requestConfiguration.Headers.Add("If-Match", IfMatch!);

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DelegatedAdminRelationshipRequestId);
                return;
            }
        }
    }
}
