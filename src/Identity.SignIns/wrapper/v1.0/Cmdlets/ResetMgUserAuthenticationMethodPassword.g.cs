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
    [GraphRoute("POST", "/users/{user-id}/authentication/methods/{authenticationMethod-id}/resetPassword")]
    [Cmdlet(VerbsCommon.Reset, "MgUserAuthenticationMethodPassword", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.PasswordResetResponse))]
    public class ResetMgUserAuthenticationMethodPasswordCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string AuthenticationMethodId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? NewPassword { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AuthenticationMethodId, "Reset"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Identity.SignIns.Client.Users.Item.Authentication.Methods.Item.ResetPassword.ResetPasswordPostRequestBody();

    if (this.IsParameterBound(nameof(NewPassword)))
        body.NewPassword = NewPassword;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.PasswordResetResponse? result;
            try
            {
                result = client.Users[UserId].Authentication.Methods[AuthenticationMethodId].ResetPassword.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, AuthenticationMethodId);
                return;
            }

            WriteObject(result);
        }
    }
}
