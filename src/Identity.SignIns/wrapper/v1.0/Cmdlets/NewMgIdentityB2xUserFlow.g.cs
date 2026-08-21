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
    [GraphRoute("POST", "/identity/b2xUserFlows")]
    [Cmdlet(VerbsCommon.New, "MgIdentityB2XUserFlow", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.B2xIdentityUserFlow))]
    public class NewMgIdentityB2XUserFlowCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public float? UserFlowTypeVersion { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.UserFlowType? UserFlowType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.UserFlowApiConnectorConfiguration? ApiConnectorConfiguration { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
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
                result = client.Identity.B2xUserFlows.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
