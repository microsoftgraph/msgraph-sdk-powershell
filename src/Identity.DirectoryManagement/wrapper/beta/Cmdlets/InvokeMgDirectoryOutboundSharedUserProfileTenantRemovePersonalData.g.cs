#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.DirectoryManagement
{
    [GraphRoute("POST", "/directory/outboundSharedUserProfiles/{outboundSharedUserProfile-userId}/tenants/{tenantReference-tenantId}/removePersonalData")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDirectoryOutboundSharedUserProfileTenantRemovePersonalData", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgDirectoryOutboundSharedUserProfileTenantRemovePersonalDataCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string OutboundSharedUserProfileUserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string TenantReferenceTenantId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(TenantReferenceTenantId, "Invoke"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Directory.OutboundSharedUserProfiles[OutboundSharedUserProfileUserId].Tenants[TenantReferenceTenantId].RemovePersonalData.PostAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, TenantReferenceTenantId);
                return;
            }

        }
    }
}
