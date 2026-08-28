#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.Partner.Client;
using Microsoft.Graph.PowerShell.Identity.Partner.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.Partner
{
    [GraphRoute("PATCH", "/tenantRelationships/delegatedAdminCustomers/{delegatedAdminCustomer-id}")]
    [Cmdlet(VerbsData.Update, "MgTenantRelationshipDelegatedAdminCustomer", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Partner.Client.Models.DelegatedAdminCustomer))]
    public class UpdateMgTenantRelationshipDelegatedAdminCustomerCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DelegatedAdminCustomerId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? TenantId { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DelegatedAdminCustomerId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Partner.Client.Models.DelegatedAdminCustomer();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(TenantId)))
        body.TenantId = TenantId;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Partner.Client.Models.DelegatedAdminCustomer? result;
            try
            {
                result = client.TenantRelationships.DelegatedAdminCustomers[DelegatedAdminCustomerId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, DelegatedAdminCustomerId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.TenantRelationships.DelegatedAdminCustomers[DelegatedAdminCustomerId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, DelegatedAdminCustomerId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
