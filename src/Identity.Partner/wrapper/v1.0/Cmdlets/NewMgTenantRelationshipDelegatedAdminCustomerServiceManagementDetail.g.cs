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
    [GraphRoute("POST", "/tenantRelationships/delegatedAdminCustomers/{delegatedAdminCustomer-id}/serviceManagementDetails")]
    [Cmdlet(VerbsCommon.New, "MgTenantRelationshipDelegatedAdminCustomerServiceManagementDetail", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Partner.Client.Models.DelegatedAdminServiceManagementDetail))]
    public class NewMgTenantRelationshipDelegatedAdminCustomerServiceManagementDetailCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DelegatedAdminCustomerId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? ServiceManagementUrl { get; set; }

        [Parameter(Mandatory = false)]
        public string? ServiceName { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DelegatedAdminCustomerId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Partner.Client.Models.DelegatedAdminServiceManagementDetail();

    if (this.IsParameterBound(nameof(ServiceManagementUrl)))
        body.ServiceManagementUrl = ServiceManagementUrl;

    if (this.IsParameterBound(nameof(ServiceName)))
        body.ServiceName = ServiceName;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Partner.Client.Models.DelegatedAdminServiceManagementDetail? result;
            try
            {
                result = client.TenantRelationships.DelegatedAdminCustomers[DelegatedAdminCustomerId].ServiceManagementDetails.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
