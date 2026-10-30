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
    [GraphRoute("POST", "/identity/b2cUserFlows/{b2cIdentityUserFlow-id}/languages/{userFlowLanguageConfiguration-id}/overridesPages")]
    [Cmdlet(VerbsCommon.New, "MgIdentityB2cUserFlowLanguageOverridePage", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.UserFlowLanguagePage))]
    public class NewMgIdentityB2cUserFlowLanguageOverridePageCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string B2cIdentityUserFlowId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string UserFlowLanguageConfigurationId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UserFlowLanguageConfigurationId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.UserFlowLanguagePage();




        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.UserFlowLanguagePage? result;
            try
            {
                result = client.Identity.B2cUserFlows[B2cIdentityUserFlowId].Languages[UserFlowLanguageConfigurationId].OverridesPages.PostAsync(body, requestConfiguration =>
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
