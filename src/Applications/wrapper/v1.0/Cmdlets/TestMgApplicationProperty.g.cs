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
    [GraphRoute("POST", "/applications/validateProperties")]
    [Cmdlet(VerbsDiagnostic.Test, "MgApplicationProperty", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class TestMgApplicationPropertyCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? EntityType { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? MailNickname { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.Guid? OnBehalfOfUserId { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Test"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Applications.Client.Applications.ValidateProperties.ValidatePropertiesPostRequestBody();

    if (this.IsParameterBound(nameof(EntityType)))
        body.EntityType = EntityType;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(MailNickname)))
        body.MailNickname = MailNickname;

    if (this.IsParameterBound(nameof(OnBehalfOfUserId)))
        body.OnBehalfOfUserId = OnBehalfOfUserId;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Applications.ValidateProperties.PostAsync(body, requestConfiguration =>
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
