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
    [GraphRoute("POST", "/directory/administrativeUnits/{administrativeUnit-id}/scopedRoleMembers")]
    [Cmdlet(VerbsCommon.New, "MgDirectoryAdministrativeUnitScopedRoleMember", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.ScopedRoleMembership))]
    public class NewMgDirectoryAdministrativeUnitScopedRoleMemberCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AdministrativeUnitId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? AdministrativeUnitId1 { get; set; }

        [Parameter(Mandatory = false)]
        public string? RoleId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.Identity? RoleMemberInfo { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AdministrativeUnitId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.ScopedRoleMembership();

    if (this.IsParameterBound(nameof(AdministrativeUnitId1)))
        body.AdministrativeUnitId = AdministrativeUnitId1;

    if (this.IsParameterBound(nameof(RoleId)))
        body.RoleId = RoleId;

    if (this.IsParameterBound(nameof(RoleMemberInfo)))
        body.RoleMemberInfo = RoleMemberInfo;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.ScopedRoleMembership? result;
            try
            {
                result = client.Directory.AdministrativeUnits[AdministrativeUnitId].ScopedRoleMembers.PostAsync(body, requestConfiguration =>
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
