#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.SignIns
{
    [GraphRoute("GET", "/identity/b2xUserFlows/{b2xIdentityUserFlow-id}/apiConnectorConfiguration/postFederationSignup/$ref")]
    [Cmdlet(VerbsCommon.Get, "MgIdentityB2XUserFlowPostFederationSignupByRef")]
    [OutputType(typeof(string))]
    public class GetMgIdentityB2XUserFlowPostFederationSignupByRefCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string B2xIdentityUserFlowId { get; set; } = string.Empty;







        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            string? result;
            try
            {
                result = client.Identity.B2xUserFlows[B2xIdentityUserFlowId].ApiConnectorConfiguration.PostFederationSignup.Ref.GetAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, B2xIdentityUserFlowId);
                return;
            }

            if (result is not null)
                WriteObject(result);
        }
    }
}
