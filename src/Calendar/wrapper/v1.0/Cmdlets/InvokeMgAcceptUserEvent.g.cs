#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Calendar.Client;
using Microsoft.Graph.PowerShell.Calendar.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Calendar
{
    [GraphRoute("POST", "/users/{user-id}/events/{event-id}/accept")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgAcceptUserEvent", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgAcceptUserEventCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string EventId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? SendResponse { get; set; }

        [Parameter(Mandatory = false)]
        public string? Comment { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(EventId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Calendar.Client.Users.Item.Events.Item.Accept.AcceptPostRequestBody();

    if (this.IsParameterBound(nameof(SendResponse)))
        body.SendResponse = SendResponse;

    if (this.IsParameterBound(nameof(Comment)))
        body.Comment = Comment;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Users[UserId].Events[EventId].Accept.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, EventId);
                return;
            }

        }
    }
}
