#nullable enable

using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.Governance.Client;
using Microsoft.Graph.PowerShell.Identity.Governance.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.Governance
{
    [GraphRoute("GET", "/identityGovernance/entitlementManagement/assignments/additionalAccess(accessPackageId='{accessPackageId}',incompatibleAccessPackageId='{incompatibleAccessPackageId}')")]
    [Cmdlet(VerbsCommon.Get, "MgIdentityGovernanceEntitlementManagementAssignmentAdditionalAccessWithAccessPackageIdWithIncompatibleAccessPackageId")]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Identity.Governance.Client.IdentityGovernance.EntitlementManagement.Assignments.AdditionalAccessWithAccessPackageIdWithIncompatibleAccessPackageId.AdditionalAccessWithAccessPackageIdWithIncompatibleAccessPackageIdGetResponse))]
    public class GetMgIdentityGovernanceEntitlementManagementAssignmentAdditionalAccessWithAccessPackageIdWithIncompatibleAccessPackageIdCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = true, Position = 0,
            HelpMessage = "Value for the 'accessPackageId' parameter of this OData function.")]
        public string AccessPackageId { get; set; } = string.Empty;

        [Parameter(Mandatory = true, Position = 1,
            HelpMessage = "Value for the 'incompatibleAccessPackageId' parameter of this OData function.")]
        public string IncompatibleAccessPackageId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        public string? Filter { get; set; }

        [Parameter(Mandatory = false)]
        [Alias("Select")]
        public string[]? Property { get; set; }

        [Parameter(Mandatory = false)]
        [Alias("Expand")]
        public string[]? ExpandProperty { get; set; }

        [Parameter(Mandatory = false)]
        [Alias("OrderBy")]
        public string[]? Sort { get; set; }

        [Parameter(Mandatory = false)]
        public string? Search { get; set; }

        [Parameter(Mandatory = false)]
        public int Top { get; set; }

        [Parameter(Mandatory = false)]
        public int Skip { get; set; }

        [Parameter(Mandatory = false)]
        public SwitchParameter Count { get; set; }




        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

        var pathParameters = new Dictionary<string, object>
        {
            { "baseurl", requestAdapter.BaseUrl! },
            { "accessPackageId", AccessPackageId },
            { "incompatibleAccessPackageId", IncompatibleAccessPackageId },
        };
        var requestBuilder = new global::Microsoft.Graph.PowerShell.Identity.Governance.Client.IdentityGovernance.EntitlementManagement.Assignments.AdditionalAccessWithAccessPackageIdWithIncompatibleAccessPackageId.AdditionalAccessWithAccessPackageIdWithIncompatibleAccessPackageIdRequestBuilder(pathParameters, requestAdapter);

            global::Microsoft.Graph.PowerShell.Identity.Governance.Client.IdentityGovernance.EntitlementManagement.Assignments.AdditionalAccessWithAccessPackageIdWithIncompatibleAccessPackageId.AdditionalAccessWithAccessPackageIdWithIncompatibleAccessPackageIdGetResponse? result;
            try
            {
                result = requestBuilder.GetAsAdditionalAccessWithAccessPackageIdWithIncompatibleAccessPackageIdGetResponseAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Filter)))
                        requestConfiguration.QueryParameters.Filter = Filter;

                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;

                    if (this.IsParameterBound(nameof(Sort)))
                        requestConfiguration.QueryParameters.Orderby = Sort;

                    if (this.IsParameterBound(nameof(Search)))
                        requestConfiguration.QueryParameters.Search = Search;

                    if (this.IsParameterBound(nameof(Top)))
                        requestConfiguration.QueryParameters.Top = Top;

                    if (this.IsParameterBound(nameof(Skip)))
                        requestConfiguration.QueryParameters.Skip = Skip;

                    if (Count.IsPresent)
                        requestConfiguration.QueryParameters.Count = true;

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }

            WriteObject(result);
        }
    }
}
