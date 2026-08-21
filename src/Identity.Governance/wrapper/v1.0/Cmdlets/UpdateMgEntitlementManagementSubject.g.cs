#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.Governance.Client;
using Microsoft.Graph.PowerShell.Identity.Governance.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.Governance
{
    [GraphRoute("PATCH", "/identityGovernance/entitlementManagement/subjects/{accessPackageSubject-id}")]
    [Cmdlet(VerbsData.Update, "MgEntitlementManagementSubject", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessPackageSubject))]
    public class UpdateMgEntitlementManagementSubjectCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AccessPackageSubjectId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? Email { get; set; }

        [Parameter(Mandatory = false)]
        public string? ObjectId { get; set; }

        [Parameter(Mandatory = false)]
        public string? OnPremisesSecurityIdentifier { get; set; }

        [Parameter(Mandatory = false)]
        public string? PrincipalName { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessPackageSubjectLifecycle? SubjectLifecycle { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessPackageSubjectType? SubjectType { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AccessPackageSubjectId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessPackageSubject();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(Email)))
        body.Email = Email;

    if (this.IsParameterBound(nameof(ObjectId)))
        body.ObjectId = ObjectId;

    if (this.IsParameterBound(nameof(OnPremisesSecurityIdentifier)))
        body.OnPremisesSecurityIdentifier = OnPremisesSecurityIdentifier;

    if (this.IsParameterBound(nameof(PrincipalName)))
        body.PrincipalName = PrincipalName;

    if (this.IsParameterBound(nameof(SubjectLifecycle)))
        body.SubjectLifecycle = SubjectLifecycle;

    if (this.IsParameterBound(nameof(SubjectType)))
        body.SubjectType = SubjectType;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessPackageSubject? result;
            try
            {
                result = client.IdentityGovernance.EntitlementManagement.Subjects[AccessPackageSubjectId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, AccessPackageSubjectId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.IdentityGovernance.EntitlementManagement.Subjects[AccessPackageSubjectId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, AccessPackageSubjectId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
