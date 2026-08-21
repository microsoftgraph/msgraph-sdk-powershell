#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Sites.Client;
using Microsoft.Graph.PowerShell.Sites.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Sites
{
    [GraphRoute("PATCH", "/sites/{site-id}/permissions/{permission-id}")]
    [Cmdlet(VerbsData.Update, "MgSitePermission", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Sites.Client.Models.Permission))]
    public class UpdateMgSitePermissionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SiteId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string PermissionId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ExpirationDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public bool? HasPassword { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? Roles { get; set; }

        [Parameter(Mandatory = false)]
        public string? ShareId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.IdentitySet? GrantedTo { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.IdentitySet[]? GrantedToIdentities { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.SharePointIdentitySet[]? GrantedToIdentitiesV2 { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.SharePointIdentitySet? GrantedToV2 { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.ItemReference? InheritedFrom { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.SharingInvitation? Invitation { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.SharingLink? Link { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PermissionId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Sites.Client.Models.Permission();

    if (this.IsParameterBound(nameof(ExpirationDateTime)))
        body.ExpirationDateTime = ExpirationDateTime;

    if (this.IsParameterBound(nameof(HasPassword)))
        body.HasPassword = HasPassword;

    if (this.IsParameterBound(nameof(Roles)))
        body.Roles = Roles!.ToList();

    if (this.IsParameterBound(nameof(ShareId)))
        body.ShareId = ShareId;

    if (this.IsParameterBound(nameof(GrantedTo)))
        body.GrantedTo = GrantedTo;

    if (this.IsParameterBound(nameof(GrantedToIdentities)))
        body.GrantedToIdentities = GrantedToIdentities!.ToList();

    if (this.IsParameterBound(nameof(GrantedToIdentitiesV2)))
        body.GrantedToIdentitiesV2 = GrantedToIdentitiesV2!.ToList();

    if (this.IsParameterBound(nameof(GrantedToV2)))
        body.GrantedToV2 = GrantedToV2;

    if (this.IsParameterBound(nameof(InheritedFrom)))
        body.InheritedFrom = InheritedFrom;

    if (this.IsParameterBound(nameof(Invitation)))
        body.Invitation = Invitation;

    if (this.IsParameterBound(nameof(Link)))
        body.Link = Link;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Sites.Client.Models.Permission? result;
            try
            {
                result = client.Sites[SiteId].Permissions[PermissionId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, PermissionId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Sites[SiteId].Permissions[PermissionId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, PermissionId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
