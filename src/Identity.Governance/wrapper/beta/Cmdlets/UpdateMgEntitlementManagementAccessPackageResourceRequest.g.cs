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
    [GraphRoute("PATCH", "/identityGovernance/entitlementManagement/accessPackageResourceRequests/{accessPackageResourceRequest-id}")]
    [Cmdlet(VerbsData.Update, "MgEntitlementManagementAccessPackageResourceRequest", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessPackageResourceRequest))]
    public class UpdateMgEntitlementManagementAccessPackageResourceRequestCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AccessPackageResourceRequestId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? CatalogId { get; set; }

        [Parameter(Mandatory = false)]
        public bool? ExecuteImmediately { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ExpirationDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsValidationOnly { get; set; }

        [Parameter(Mandatory = false)]
        public string? Justification { get; set; }

        [Parameter(Mandatory = false)]
        public string? RequestState { get; set; }

        [Parameter(Mandatory = false)]
        public string? RequestStatus { get; set; }

        [Parameter(Mandatory = false)]
        public string? RequestType { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AccessPackageResourceRequestId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessPackageResourceRequest();

    if (this.IsParameterBound(nameof(CatalogId)))
        body.CatalogId = CatalogId;

    if (this.IsParameterBound(nameof(ExecuteImmediately)))
        body.ExecuteImmediately = ExecuteImmediately;

    if (this.IsParameterBound(nameof(ExpirationDateTime)))
        body.ExpirationDateTime = ExpirationDateTime;

    if (this.IsParameterBound(nameof(IsValidationOnly)))
        body.IsValidationOnly = IsValidationOnly;

    if (this.IsParameterBound(nameof(Justification)))
        body.Justification = Justification;

    if (this.IsParameterBound(nameof(RequestState)))
        body.RequestState = RequestState;

    if (this.IsParameterBound(nameof(RequestStatus)))
        body.RequestStatus = RequestStatus;

    if (this.IsParameterBound(nameof(RequestType)))
        body.RequestType = RequestType;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessPackageResourceRequest? result;
            try
            {
                result = client.IdentityGovernance.EntitlementManagement.AccessPackageResourceRequests[AccessPackageResourceRequestId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, AccessPackageResourceRequestId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.IdentityGovernance.EntitlementManagement.AccessPackageResourceRequests[AccessPackageResourceRequestId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, AccessPackageResourceRequestId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
