#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.SignIns
{
    [GraphRoute("PATCH", "/policies/crossTenantAccessPolicy/templates/multiTenantOrganizationIdentitySynchronization")]
    [Cmdlet(VerbsData.Update, "MgPolicyCrossTenantAccessPolicyTemplateMultiTenantOrganizationIdentitySynchronization", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.MultiTenantOrganizationIdentitySyncPolicyTemplate))]
    public class UpdateMgPolicyCrossTenantAccessPolicyTemplateMultiTenantOrganizationIdentitySynchronizationCommand : GraphClientCmdlet
    {



        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.TemplateApplicationLevel? TemplateApplicationLevel { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.CrossTenantUserSyncInbound? UserSyncInbound { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.MultiTenantOrganizationIdentitySyncPolicyTemplate();


    if (this.IsParameterBound(nameof(TemplateApplicationLevel)))
        body.TemplateApplicationLevel = TemplateApplicationLevel;

    if (this.IsParameterBound(nameof(UserSyncInbound)))
        body.UserSyncInbound = UserSyncInbound;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.MultiTenantOrganizationIdentitySyncPolicyTemplate? result;
            try
            {
                result = client.Policies.CrossTenantAccessPolicy.Templates.MultiTenantOrganizationIdentitySynchronization.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Policies.CrossTenantAccessPolicy.Templates.MultiTenantOrganizationIdentitySynchronization.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, null);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
