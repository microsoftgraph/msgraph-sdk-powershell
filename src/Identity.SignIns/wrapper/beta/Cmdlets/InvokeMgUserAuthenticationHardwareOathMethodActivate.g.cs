#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.SignIns
{
    [GraphRoute("POST", "/users/{user-id}/authentication/hardwareOathMethods/{hardwareOathAuthenticationMethod-id}/activate")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgUserAuthenticationHardwareOathMethodActivate", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgUserAuthenticationHardwareOathMethodActivateCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string HardwareOathAuthenticationMethodId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? VerificationCode { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(HardwareOathAuthenticationMethodId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Identity.SignIns.Client.Users.Item.Authentication.HardwareOathMethods.Item.Activate.ActivatePostRequestBody();

    if (this.IsParameterBound(nameof(VerificationCode)))
        body.VerificationCode = VerificationCode;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Users[UserId].Authentication.HardwareOathMethods[HardwareOathAuthenticationMethodId].Activate.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, HardwareOathAuthenticationMethodId);
                return;
            }

        }
    }
}
