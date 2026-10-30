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
    [GraphRoute("POST", "/domains/{domain-id}/sharedEmailDomainInvitations")]
    [Cmdlet(VerbsCommon.New, "MgDomainSharedEmailDomainInvitation", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.SharedEmailDomainInvitation))]
    public class NewMgDomainSharedEmailDomainInvitationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DomainId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ExpiryTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? InvitationDomain { get; set; }

        [Parameter(Mandatory = false)]
        public string? InvitationStatus { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DomainId, "New"))
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
                result = client.Domains[DomainId].SharedEmailDomainInvitations.PostAsync(body, requestConfiguration =>
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
