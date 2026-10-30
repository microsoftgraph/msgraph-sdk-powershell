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
    [GraphRoute("PATCH", "/identity/b2cUserFlows/{b2cIdentityUserFlow-id}")]
    [Cmdlet(VerbsData.Update, "MgIdentityB2cUserFlow", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.B2cIdentityUserFlow))]
    public class UpdateMgIdentityB2cUserFlowCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string B2cIdentityUserFlowId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public float? UserFlowTypeVersion { get; set; }

        [Parameter(Mandatory = false)]
        public string? DefaultLanguageTag { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsLanguageCustomizationEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.UserFlowType? UserFlowType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.UserFlowApiConnectorConfiguration? ApiConnectorConfiguration { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(B2cIdentityUserFlowId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.B2cIdentityUserFlow();

    if (this.IsParameterBound(nameof(UserFlowTypeVersion)))
        body.UserFlowTypeVersion = UserFlowTypeVersion;

    if (this.IsParameterBound(nameof(DefaultLanguageTag)))
        body.DefaultLanguageTag = DefaultLanguageTag;

    if (this.IsParameterBound(nameof(IsLanguageCustomizationEnabled)))
        body.IsLanguageCustomizationEnabled = IsLanguageCustomizationEnabled;

    if (this.IsParameterBound(nameof(UserFlowType)))
        body.UserFlowType = UserFlowType;

    if (this.IsParameterBound(nameof(ApiConnectorConfiguration)))
        body.ApiConnectorConfiguration = ApiConnectorConfiguration;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.B2cIdentityUserFlow? result;
            try
            {
                result = client.Identity.B2cUserFlows[B2cIdentityUserFlowId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, B2cIdentityUserFlowId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Identity.B2cUserFlows[B2cIdentityUserFlowId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, B2cIdentityUserFlowId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
