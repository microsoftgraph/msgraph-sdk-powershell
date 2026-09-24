#nullable enable

using System;
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
    [GraphRoute("GET", "/reports/authenticationMethods/userPasswordResetsAndChangesSummary/{userPasswordResetsAndChangesSummary-id}")]
    [Cmdlet(VerbsCommon.Get, "MgReportAuthenticationMethodUserPasswordResetAndChangeSummary_Get")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Reports.Client.Models.UserPasswordResetsAndChangesSummary))]
    public class GetMgReportAuthenticationMethodUserPasswordResetAndChangeSummary_GetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserPasswordResetsAndChangesSummaryId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        [Alias("Select")]
        public string[]? Property { get; set; }
        [Parameter(Mandatory = false)]
        [Alias("Expand")]
        public string[]? ExpandProperty { get; set; }



        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Reports.Client.Models.UserPasswordResetsAndChangesSummary? result;
            try
            {
                result = client.Reports.AuthenticationMethods.UserPasswordResetsAndChangesSummary[UserPasswordResetsAndChangesSummaryId].GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;



        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, UserPasswordResetsAndChangesSummaryId);
                return;
            }

            WriteObject(result);
        }
    }
}
