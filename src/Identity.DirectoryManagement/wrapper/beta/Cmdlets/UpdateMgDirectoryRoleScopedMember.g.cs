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
    [GraphRoute("PATCH", "/directoryRoles/{directoryRole-id}/scopedMembers/{scopedRoleMembership-id}")]
    [Cmdlet(VerbsData.Update, "MgDirectoryRoleScopedMember", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.ScopedRoleMembership))]
    public class UpdateMgDirectoryRoleScopedMemberCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DirectoryRoleId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ScopedRoleMembershipId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? AdministrativeUnitId { get; set; }

        [Parameter(Mandatory = false)]
        public string? RoleId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.Identity? RoleMemberInfo { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ScopedRoleMembershipId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.ScopedRoleMembership();

    if (this.IsParameterBound(nameof(AdministrativeUnitId)))
        body.AdministrativeUnitId = AdministrativeUnitId;

    if (this.IsParameterBound(nameof(RoleId)))
        body.RoleId = RoleId;

    if (this.IsParameterBound(nameof(RoleMemberInfo)))
        body.RoleMemberInfo = RoleMemberInfo;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.ScopedRoleMembership? result;
            try
            {
                result = client.DirectoryRoles[DirectoryRoleId].ScopedMembers[ScopedRoleMembershipId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ScopedRoleMembershipId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DirectoryRoles[DirectoryRoleId].ScopedMembers[ScopedRoleMembershipId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, ScopedRoleMembershipId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
