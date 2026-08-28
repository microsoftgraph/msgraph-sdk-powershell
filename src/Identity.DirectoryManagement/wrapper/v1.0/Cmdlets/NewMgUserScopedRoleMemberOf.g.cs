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
    [GraphRoute("POST", "/users/{user-id}/scopedRoleMemberOf")]
    [Cmdlet(VerbsCommon.New, "MgUserScopedRoleMemberOf", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.ScopedRoleMembership))]
    public class NewMgUserScopedRoleMemberOfCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? AdministrativeUnitId { get; set; }

        [Parameter(Mandatory = false)]
        public string? RoleId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.Identity? RoleMemberInfo { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UserId, "New"))
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
                result = client.Users[UserId].ScopedRoleMemberOf.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
