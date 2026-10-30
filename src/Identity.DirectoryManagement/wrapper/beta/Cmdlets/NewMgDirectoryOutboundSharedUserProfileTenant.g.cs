#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.DirectoryManagement
{
    [GraphRoute("POST", "/directory/outboundSharedUserProfiles/{outboundSharedUserProfile-userId}/tenants")]
    [Cmdlet(VerbsCommon.New, "MgDirectoryOutboundSharedUserProfileTenant", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.TenantReference))]
    public class NewMgDirectoryOutboundSharedUserProfileTenantCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string OutboundSharedUserProfileUserId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? TenantId { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(OutboundSharedUserProfileUserId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.TenantReference();

    if (this.IsParameterBound(nameof(TenantId)))
        body.TenantId = TenantId;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.TenantReference? result;
            try
            {
                result = client.Directory.OutboundSharedUserProfiles[OutboundSharedUserProfileUserId].Tenants.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
