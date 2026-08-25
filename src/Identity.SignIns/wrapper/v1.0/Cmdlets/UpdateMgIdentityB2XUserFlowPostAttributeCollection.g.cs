#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.SignIns
{
    [GraphRoute("PATCH", "/identity/b2xUserFlows/{b2xIdentityUserFlow-id}/apiConnectorConfiguration/postAttributeCollection")]
    [Cmdlet(VerbsData.Update, "MgIdentityB2XUserFlowPostAttributeCollection", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.IdentityApiConnector))]
    public class UpdateMgIdentityB2XUserFlowPostAttributeCollectionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string B2xIdentityUserFlowId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? TargetUrl { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.ApiAuthenticationConfigurationBase? AuthenticationConfiguration { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(B2xIdentityUserFlowId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.IdentityApiConnector();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(TargetUrl)))
        body.TargetUrl = TargetUrl;

    if (this.IsParameterBound(nameof(AuthenticationConfiguration)))
        body.AuthenticationConfiguration = AuthenticationConfiguration;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.IdentityApiConnector? result;
            try
            {
                result = client.Identity.B2xUserFlows[B2xIdentityUserFlowId].ApiConnectorConfiguration.PostAttributeCollection.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, B2xIdentityUserFlowId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Identity.B2xUserFlows[B2xIdentityUserFlowId].ApiConnectorConfiguration.PostAttributeCollection.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, B2xIdentityUserFlowId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
