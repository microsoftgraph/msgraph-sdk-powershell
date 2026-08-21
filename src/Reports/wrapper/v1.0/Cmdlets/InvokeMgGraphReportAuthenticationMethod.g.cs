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
    [GraphRoute("GET", "/reports/authenticationMethods/usersRegisteredByFeature()")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgGraphReportAuthenticationMethod")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Reports.Client.Models.UserRegistrationFeatureSummary))]
    public class InvokeMgGraphReportAuthenticationMethodCommand : GraphClientCmdlet
    {










        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            Microsoft.Graph.PowerShell.Reports.Client.Models.UserRegistrationFeatureSummary? result;
            try
            {
                result = client.Reports.AuthenticationMethods.UsersRegisteredByFeature.GetAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }

            WriteObject(result);
        }
    }
}
