#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Security.Client;
using Microsoft.Graph.PowerShell.Security.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Security
{
    [GraphRoute("POST", "/security/identities/identityAccounts/{identityAccounts-id}/microsoft.graph.security.invokeAction")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgSecurityIdentityAccountInvokeAction", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.Security.InvokeActionResult))]
    public class InvokeMgSecurityIdentityAccountInvokeActionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string IdentityAccountsId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? AccountId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.ActionObject? Action { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.IdentityProvider? IdentityProvider { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(IdentityAccountsId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Security.Client.Security.Identities.IdentityAccounts.Item.MicrosoftGraphSecurityInvokeAction.InvokeActionPostRequestBody();

    if (this.IsParameterBound(nameof(AccountId)))
        body.AccountId = AccountId;
    if (this.IsParameterBound(nameof(Action)))
        body.Action = Action;

    if (this.IsParameterBound(nameof(IdentityProvider)))
        body.IdentityProvider = IdentityProvider;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.Security.InvokeActionResult? result;
            try
            {
                result = client.Security.Identities.IdentityAccounts[IdentityAccountsId].MicrosoftGraphSecurityInvokeAction.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, IdentityAccountsId);
                return;
            }

            WriteObject(result);
        }
    }
}
