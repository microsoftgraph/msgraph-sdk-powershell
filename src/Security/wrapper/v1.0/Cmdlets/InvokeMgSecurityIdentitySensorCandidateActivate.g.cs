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
    [GraphRoute("POST", "/security/identities/sensorCandidates/microsoft.graph.security.activate")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgSecurityIdentitySensorCandidateActivate", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgSecurityIdentitySensorCandidateActivateCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string[]? ServerIds { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Security.Client.Security.Identities.SensorCandidates.MicrosoftGraphSecurityActivate.ActivatePostRequestBody();

    if (this.IsParameterBound(nameof(ServerIds)))
        body.ServerIds = ServerIds!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Security.Identities.SensorCandidates.MicrosoftGraphSecurityActivate.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }

        }
    }
}
