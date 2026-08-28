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
    [GraphRoute("PATCH", "/identity/b2xUserFlows/{b2xIdentityUserFlow-id}")]
    [Cmdlet(VerbsData.Update, "MgIdentityB2XUserFlow", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.B2xIdentityUserFlow))]
    public class UpdateMgIdentityB2XUserFlowCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string B2xIdentityUserFlowId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public float? UserFlowTypeVersion { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.UserFlowType? UserFlowType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.UserFlowApiConnectorConfiguration? ApiConnectorConfiguration { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(B2xIdentityUserFlowId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.B2xIdentityUserFlow();

    if (this.IsParameterBound(nameof(UserFlowTypeVersion)))
        body.UserFlowTypeVersion = UserFlowTypeVersion;

    if (this.IsParameterBound(nameof(UserFlowType)))
        body.UserFlowType = UserFlowType;

    if (this.IsParameterBound(nameof(ApiConnectorConfiguration)))
        body.ApiConnectorConfiguration = ApiConnectorConfiguration;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.B2xIdentityUserFlow? result;
            try
            {
                result = client.Identity.B2xUserFlows[B2xIdentityUserFlowId].PatchAsync(body, requestConfiguration =>
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
                    result = client.Identity.B2xUserFlows[B2xIdentityUserFlowId].GetAsync().GetAwaiter().GetResult();
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
