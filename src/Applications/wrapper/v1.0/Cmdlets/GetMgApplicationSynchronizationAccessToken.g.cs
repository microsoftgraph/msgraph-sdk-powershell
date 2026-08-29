#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Applications.Client;
using Microsoft.Graph.PowerShell.Applications.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Applications
{
    [GraphRoute("POST", "/applications/{application-id}/synchronization/acquireAccessToken")]
    [Cmdlet(VerbsCommon.Get, "MgApplicationSynchronizationAccessToken", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class GetMgApplicationSynchronizationAccessTokenCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ApplicationId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.SynchronizationSecretKeyStringValuePair[]? Credentials { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ApplicationId, "Get"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Applications.Client.Applications.Item.Synchronization.AcquireAccessToken.AcquireAccessTokenPostRequestBody();

    if (this.IsParameterBound(nameof(Credentials)))
        body.Credentials = Credentials!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Applications[ApplicationId].Synchronization.AcquireAccessToken.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ApplicationId);
                return;
            }

        }
    }
}
