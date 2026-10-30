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
    [GraphRoute("POST", "/identityGovernance/entitlementManagement/accessPackageResourceRequests")]
    [Cmdlet(VerbsCommon.New, "MgEntitlementManagementAccessPackageResourceRequest", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessPackageResourceRequest))]
    public class NewMgEntitlementManagementAccessPackageResourceRequestCommand : GraphClientCmdlet
    {


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
            if (!ShouldProcess(null, "New"))
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
                result = client.IdentityGovernance.EntitlementManagement.AccessPackageResourceRequests.PostAsync(body, requestConfiguration =>
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
