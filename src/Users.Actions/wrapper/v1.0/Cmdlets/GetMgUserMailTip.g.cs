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
    [GraphRoute("POST", "/users/{user-id}/getMailTips")]
    [Cmdlet(VerbsCommon.Get, "MgUserMailTip", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Users.Actions.Client.Users.Item.GetMailTips.GetMailTipsPostResponse))]
    public class GetMgUserMailTipCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string[]? EmailAddresses { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Users.Actions.Client.Models.MailTipsType? MailTipsOptions { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UserId, "Get"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Users.Actions.Client.Users.Item.GetMailTips.GetMailTipsPostRequestBody();

    if (this.IsParameterBound(nameof(EmailAddresses)))
        body.EmailAddresses = EmailAddresses!.ToList();
    if (this.IsParameterBound(nameof(MailTipsOptions)))
        body.MailTipsOptions = MailTipsOptions;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.Users.Actions.Client.Users.Item.GetMailTips.GetMailTipsPostResponse? result;
            try
            {
                result = client.Users[UserId].GetMailTips.PostAsGetMailTipsPostResponseAsync(body, requestConfiguration =>
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
