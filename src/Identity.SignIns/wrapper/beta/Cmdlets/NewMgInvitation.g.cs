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
    [GraphRoute("POST", "/invitations")]
    [Cmdlet(VerbsCommon.New, "MgInvitation", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.Invitation))]
    public class NewMgInvitationCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? InvitedUserDisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? InvitedUserEmailAddress { get; set; }

        [Parameter(Mandatory = false)]
        public string? InvitedUserType { get; set; }

        [Parameter(Mandatory = false)]
        public string? InviteRedeemUrl { get; set; }

        [Parameter(Mandatory = false)]
        public string? InviteRedirectUrl { get; set; }

        [Parameter(Mandatory = false)]
        public bool? ResetRedemption { get; set; }

        [Parameter(Mandatory = false)]
        public bool? SendInvitationMessage { get; set; }

        [Parameter(Mandatory = false)]
        public string? Status { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.InvitedUserMessageInfo? InvitedUserMessageInfo { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.Invitation();

    if (this.IsParameterBound(nameof(InvitedUserDisplayName)))
        body.InvitedUserDisplayName = InvitedUserDisplayName;

    if (this.IsParameterBound(nameof(InvitedUserEmailAddress)))
        body.InvitedUserEmailAddress = InvitedUserEmailAddress;

    if (this.IsParameterBound(nameof(InvitedUserType)))
        body.InvitedUserType = InvitedUserType;

    if (this.IsParameterBound(nameof(InviteRedeemUrl)))
        body.InviteRedeemUrl = InviteRedeemUrl;

    if (this.IsParameterBound(nameof(InviteRedirectUrl)))
        body.InviteRedirectUrl = InviteRedirectUrl;

    if (this.IsParameterBound(nameof(ResetRedemption)))
        body.ResetRedemption = ResetRedemption;

    if (this.IsParameterBound(nameof(SendInvitationMessage)))
        body.SendInvitationMessage = SendInvitationMessage;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;

    if (this.IsParameterBound(nameof(InvitedUserMessageInfo)))
        body.InvitedUserMessageInfo = InvitedUserMessageInfo;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.Invitation? result;
            try
            {
                result = client.Invitations.PostAsync(body, requestConfiguration =>
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
