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
    [GraphRoute("POST", "/users/{user-id}/mailFolders/{mailFolder-id}/childFolders/{mailFolder-id1}/messages/{message-id}/copy")]
    [Cmdlet(VerbsCommon.Copy, "MgUserMailFolderChildFolderMessage", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Mail.Client.Models.Message))]
    public class CopyMgUserMailFolderChildFolderMessageCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string MailFolderId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string MailFolderId1 { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string MessageId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DestinationId { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(MessageId, "Copy"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Mail.Client.Users.Item.MailFolders.Item.ChildFolders.Item.Messages.Item.Copy.CopyPostRequestBody();

    if (this.IsParameterBound(nameof(DestinationId)))
        body.DestinationId = DestinationId;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Mail.Client.Models.Message? result;
            try
            {
                result = client.Users[UserId].MailFolders[MailFolderId].ChildFolders[MailFolderId1].Messages[MessageId].Copy.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, MessageId);
                return;
            }

            WriteObject(result);
        }
    }
}
