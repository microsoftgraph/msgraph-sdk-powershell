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
    [GraphRoute("POST", "/users/{user-id}/authentication/phoneMethods/{phoneAuthenticationMethod-id}/disableSmsSignIn")]
    [Cmdlet(VerbsLifecycle.Disable, "MgUserAuthenticationPhoneMethodSmsSignIn", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class DisableMgUserAuthenticationPhoneMethodSmsSignInCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string PhoneAuthenticationMethodId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PhoneAuthenticationMethodId, "Disable"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Users[UserId].Authentication.PhoneMethods[PhoneAuthenticationMethodId].DisableSmsSignIn.PostAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, PhoneAuthenticationMethodId);
                return;
            }

        }
    }
}
