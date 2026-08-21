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
    [GraphRoute("POST", "/applications/{application-id}/setVerifiedPublisher")]
    [Cmdlet(VerbsCommon.Set, "MgApplicationVerifiedPublisher", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class SetMgApplicationVerifiedPublisherCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ApplicationId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? VerifiedPublisherId { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ApplicationId, "Set"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Applications.Client.Applications.Item.SetVerifiedPublisher.SetVerifiedPublisherPostRequestBody();

    if (this.IsParameterBound(nameof(VerifiedPublisherId)))
        body.VerifiedPublisherId = VerifiedPublisherId;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Applications[ApplicationId].SetVerifiedPublisher.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, ApplicationId);
                return;
            }

        }
    }
}
