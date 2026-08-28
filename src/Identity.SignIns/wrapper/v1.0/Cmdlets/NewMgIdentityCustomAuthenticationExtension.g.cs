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
    [GraphRoute("POST", "/identity/customAuthenticationExtensions")]
    [Cmdlet(VerbsCommon.New, "MgIdentityCustomAuthenticationExtension", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.CustomAuthenticationExtension))]
    public class NewMgIdentityCustomAuthenticationExtensionCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.CustomExtensionAuthenticationConfiguration? AuthenticationConfiguration { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.CustomExtensionClientConfiguration? ClientConfiguration { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.CustomExtensionEndpointConfiguration? EndpointConfiguration { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.CustomExtensionBehaviorOnError? BehaviorOnError { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.CustomAuthenticationExtension();

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(AuthenticationConfiguration)))
        body.AuthenticationConfiguration = AuthenticationConfiguration;

    if (this.IsParameterBound(nameof(ClientConfiguration)))
        body.ClientConfiguration = ClientConfiguration;

    if (this.IsParameterBound(nameof(EndpointConfiguration)))
        body.EndpointConfiguration = EndpointConfiguration;

    if (this.IsParameterBound(nameof(BehaviorOnError)))
        body.BehaviorOnError = BehaviorOnError;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.CustomAuthenticationExtension? result;
            try
            {
                result = client.Identity.CustomAuthenticationExtensions.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
