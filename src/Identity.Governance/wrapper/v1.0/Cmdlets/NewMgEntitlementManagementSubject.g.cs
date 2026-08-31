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
    [GraphRoute("POST", "/identityGovernance/entitlementManagement/subjects")]
    [Cmdlet(VerbsCommon.New, "MgEntitlementManagementSubject", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessPackageSubject))]
    public class NewMgEntitlementManagementSubjectCommand : GraphClientCmdlet
    {


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
            if (!ShouldProcess(null, "New"))
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
                result = client.IdentityGovernance.EntitlementManagement.Subjects.PostAsync(body, requestConfiguration =>
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
