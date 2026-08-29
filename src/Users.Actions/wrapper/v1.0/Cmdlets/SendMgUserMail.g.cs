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
    [GraphRoute("POST", "/users/{user-id}/sendMail")]
    [Cmdlet(VerbsCommunications.Send, "MgUserMail", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class SendMgUserMailCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? SaveToSentItems { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Users.Actions.Client.Models.Message? Message { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UserId, "Send"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Users.Actions.Client.Users.Item.SendMail.SendMailPostRequestBody();

    if (this.IsParameterBound(nameof(SaveToSentItems)))
        body.SaveToSentItems = SaveToSentItems;
    if (this.IsParameterBound(nameof(Message)))
        body.Message = Message;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Users[UserId].SendMail.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, UserId);
                return;
            }

        }
    }
}
