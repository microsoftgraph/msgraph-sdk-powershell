#nullable enable

using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Reports.Client;
using Microsoft.Graph.PowerShell.Reports.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Reports
{
    [GraphRoute("GET", "/reports/authenticationMethods/usersRegisteredByFeature(includedUserTypes='{includedUserTypes}',includedUserRoles='{includedUserRoles}')")]
    [Cmdlet(VerbsCommon.Get, "MgReportAuthenticationMethodUsersRegisteredByFeatureWithIncludedUserTypesWithIncludedUserRoles")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Reports.Client.Models.UserRegistrationFeatureSummary))]
    public class GetMgReportAuthenticationMethodUsersRegisteredByFeatureWithIncludedUserTypesWithIncludedUserRolesCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = true, Position = 0,
            HelpMessage = "Value for the 'includedUserTypes' parameter of this OData function.")]
        public string IncludedUserTypes { get; set; } = string.Empty;

        [Parameter(Mandatory = true, Position = 1,
            HelpMessage = "Value for the 'includedUserRoles' parameter of this OData function.")]
        public string IncludedUserRoles { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

        var pathParameters = new Dictionary<string, object>
        {
            { "baseurl", requestAdapter.BaseUrl! },
            { "includedUserTypes", IncludedUserTypes },
            { "includedUserRoles", IncludedUserRoles },
        };
        var requestBuilder = new global::Microsoft.Graph.PowerShell.Reports.Client.Reports.AuthenticationMethods.UsersRegisteredByFeatureWithIncludedUserTypesWithIncludedUserRoles.UsersRegisteredByFeatureWithIncludedUserTypesWithIncludedUserRolesRequestBuilder(pathParameters, requestAdapter);

            Microsoft.Graph.PowerShell.Reports.Client.Models.UserRegistrationFeatureSummary? result;
            try
            {
                result = requestBuilder.GetAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }

            WriteObject(result);
        }
    }
}
