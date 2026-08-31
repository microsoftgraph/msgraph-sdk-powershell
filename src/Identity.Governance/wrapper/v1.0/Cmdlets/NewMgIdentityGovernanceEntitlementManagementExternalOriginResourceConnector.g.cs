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
    [GraphRoute("POST", "/identityGovernance/entitlementManagement/externalOriginResourceConnectors")]
    [Cmdlet(VerbsCommon.New, "MgIdentityGovernanceEntitlementManagementExternalOriginResourceConnector", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.ExternalOriginResourceConnector))]
    public class NewMgIdentityGovernanceEntitlementManagementExternalOriginResourceConnectorCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? CreatedBy { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? ModifiedBy { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.ConnectionInfo? ConnectionInfo { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.ConnectorType? ConnectorType { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.ExternalOriginResourceConnector();

    if (this.IsParameterBound(nameof(CreatedBy)))
        body.CreatedBy = CreatedBy;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(ModifiedBy)))
        body.ModifiedBy = ModifiedBy;

    if (this.IsParameterBound(nameof(ModifiedDateTime)))
        body.ModifiedDateTime = ModifiedDateTime;

    if (this.IsParameterBound(nameof(ConnectionInfo)))
        body.ConnectionInfo = ConnectionInfo;

    if (this.IsParameterBound(nameof(ConnectorType)))
        body.ConnectorType = ConnectorType;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.ExternalOriginResourceConnector? result;
            try
            {
                result = client.IdentityGovernance.EntitlementManagement.ExternalOriginResourceConnectors.PostAsync(body, requestConfiguration =>
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
