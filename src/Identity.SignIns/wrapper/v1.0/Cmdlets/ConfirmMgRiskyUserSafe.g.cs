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
    [GraphRoute("POST", "/identityProtection/riskyUsers/confirmSafe")]
    [Cmdlet(VerbsLifecycle.Confirm, "MgRiskyUserSafe", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class ConfirmMgRiskyUserSafeCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string[]? UserIds { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Confirm"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Identity.SignIns.Client.IdentityProtection.RiskyUsers.ConfirmSafe.ConfirmSafePostRequestBody();

    if (this.IsParameterBound(nameof(UserIds)))
        body.UserIds = UserIds!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.IdentityProtection.RiskyUsers.ConfirmSafe.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }

        }
    }
}
