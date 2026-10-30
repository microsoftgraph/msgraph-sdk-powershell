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
    [GraphRoute("PATCH", "/domains/{domain-id}/sharedEmailDomainInvitations/{sharedEmailDomainInvitation-id}")]
    [Cmdlet(VerbsData.Update, "MgDomainSharedEmailDomainInvitation", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.SharedEmailDomainInvitation))]
    public class UpdateMgDomainSharedEmailDomainInvitationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DomainId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SharedEmailDomainInvitationId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ExpiryTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? InvitationDomain { get; set; }

        [Parameter(Mandatory = false)]
        public string? InvitationStatus { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SharedEmailDomainInvitationId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.SharedEmailDomainInvitation();

    if (this.IsParameterBound(nameof(ExpiryTime)))
        body.ExpiryTime = ExpiryTime;

    if (this.IsParameterBound(nameof(InvitationDomain)))
        body.InvitationDomain = InvitationDomain;

    if (this.IsParameterBound(nameof(InvitationStatus)))
        body.InvitationStatus = InvitationStatus;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.SharedEmailDomainInvitation? result;
            try
            {
                result = client.Domains[DomainId].SharedEmailDomainInvitations[SharedEmailDomainInvitationId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, SharedEmailDomainInvitationId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Domains[DomainId].SharedEmailDomainInvitations[SharedEmailDomainInvitationId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, SharedEmailDomainInvitationId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
