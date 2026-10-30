#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.WindowsUpdates.Client;
using Microsoft.Graph.PowerShell.WindowsUpdates.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.WindowsUpdates
{
    [GraphRoute("PATCH", "/admin/windows/updates/updatePolicies/{updatePolicy-id}/complianceChanges/{complianceChange-id}")]
    [Cmdlet(VerbsData.Update, "MgWindowsUpdatesPolicyComplianceChange", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.WindowsUpdates.Client.Models.WindowsUpdates.ComplianceChange))]
    public class UpdateMgWindowsUpdatesPolicyComplianceChangeCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UpdatePolicyId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ComplianceChangeId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsRevoked { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? RevokedDateTime { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ComplianceChangeId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.WindowsUpdates.Client.Models.WindowsUpdates.ComplianceChange();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(IsRevoked)))
        body.IsRevoked = IsRevoked;

    if (this.IsParameterBound(nameof(RevokedDateTime)))
        body.RevokedDateTime = RevokedDateTime;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.WindowsUpdates.Client.Models.WindowsUpdates.ComplianceChange? result;
            try
            {
                result = client.Admin.Windows.Updates.UpdatePolicies[UpdatePolicyId].ComplianceChanges[ComplianceChangeId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ComplianceChangeId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Admin.Windows.Updates.UpdatePolicies[UpdatePolicyId].ComplianceChanges[ComplianceChangeId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, ComplianceChangeId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
