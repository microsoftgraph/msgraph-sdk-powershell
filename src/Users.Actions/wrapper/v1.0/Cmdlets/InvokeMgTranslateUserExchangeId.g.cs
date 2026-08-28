#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Users.Actions.Client;
using Microsoft.Graph.PowerShell.Users.Actions.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Users.Actions
{
    [GraphRoute("POST", "/users/{user-id}/translateExchangeIds")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgTranslateUserExchangeId", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Users.Actions.Client.Users.Item.TranslateExchangeIds.TranslateExchangeIdsPostResponse))]
    public class InvokeMgTranslateUserExchangeIdCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string[]? InputIds { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Users.Actions.Client.Models.ExchangeIdFormat? TargetIdType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Users.Actions.Client.Models.ExchangeIdFormat? SourceIdType { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UserId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Users.Actions.Client.Users.Item.TranslateExchangeIds.TranslateExchangeIdsPostRequestBody();

    if (this.IsParameterBound(nameof(InputIds)))
        body.InputIds = InputIds!.ToList();
    if (this.IsParameterBound(nameof(TargetIdType)))
        body.TargetIdType = TargetIdType;

    if (this.IsParameterBound(nameof(SourceIdType)))
        body.SourceIdType = SourceIdType;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.Users.Actions.Client.Users.Item.TranslateExchangeIds.TranslateExchangeIdsPostResponse? result;
            try
            {
                result = client.Users[UserId].TranslateExchangeIds.PostAsTranslateExchangeIdsPostResponseAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, UserId);
                return;
            }

            WriteObject(result);
        }
    }
}
