#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Mail.Client;
using Microsoft.Graph.PowerShell.Mail.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Mail
{
    [GraphRoute("POST", "/users/{user-id}/mailFolders/{mailFolder-id}/messages/{message-id}/send")]
    [Cmdlet(VerbsCommunications.Send, "MgUserMailFolderMessage", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class SendMgUserMailFolderMessageCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string MailFolderId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string MessageId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(MessageId, "Send"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Users[UserId].MailFolders[MailFolderId].Messages[MessageId].Send.PostAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, MessageId);
                return;
            }

        }
    }
}
