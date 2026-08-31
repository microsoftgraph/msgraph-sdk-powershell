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
    [GraphRoute("POST", "/policies/authenticationMethodsPolicy/authenticationMethodConfigurations")]
    [Cmdlet(VerbsCommon.New, "MgPolicyAuthenticationMethodPolicyAuthenticationMethodConfiguration", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.AuthenticationMethodConfiguration))]
    public class NewMgPolicyAuthenticationMethodPolicyAuthenticationMethodConfigurationCommand : GraphClientCmdlet
    {



        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.ExcludeTarget[]? ExcludeTargets { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.AuthenticationMethodState? State { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.AuthenticationMethodConfiguration();


    if (this.IsParameterBound(nameof(ExcludeTargets)))
        body.ExcludeTargets = ExcludeTargets!.ToList();

    if (this.IsParameterBound(nameof(State)))
        body.State = State;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.AuthenticationMethodConfiguration? result;
            try
            {
                result = client.Policies.AuthenticationMethodsPolicy.AuthenticationMethodConfigurations.PostAsync(body, requestConfiguration =>
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
