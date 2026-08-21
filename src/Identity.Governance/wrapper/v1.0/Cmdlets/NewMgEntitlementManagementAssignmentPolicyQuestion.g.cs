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
    [GraphRoute("POST", "/identityGovernance/entitlementManagement/assignmentPolicies/{accessPackageAssignmentPolicy-id}/questions")]
    [Cmdlet(VerbsCommon.New, "MgEntitlementManagementAssignmentPolicyQuestion", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessPackageQuestion))]
    public class NewMgEntitlementManagementAssignmentPolicyQuestionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AccessPackageAssignmentPolicyId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? IsAnswerEditable { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsRequired { get; set; }

        [Parameter(Mandatory = false)]
        public int? Sequence { get; set; }

        [Parameter(Mandatory = false)]
        public string? Text { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessPackageLocalizedText[]? Localizations { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AccessPackageAssignmentPolicyId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessPackageQuestion();

    if (this.IsParameterBound(nameof(IsAnswerEditable)))
        body.IsAnswerEditable = IsAnswerEditable;

    if (this.IsParameterBound(nameof(IsRequired)))
        body.IsRequired = IsRequired;

    if (this.IsParameterBound(nameof(Sequence)))
        body.Sequence = Sequence;

    if (this.IsParameterBound(nameof(Text)))
        body.Text = Text;

    if (this.IsParameterBound(nameof(Localizations)))
        body.Localizations = Localizations!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessPackageQuestion? result;
            try
            {
                result = client.IdentityGovernance.EntitlementManagement.AssignmentPolicies[AccessPackageAssignmentPolicyId].Questions.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
