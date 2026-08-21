#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Teams.Client;
using Microsoft.Graph.PowerShell.Teams.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Teams
{
    [GraphRoute("PATCH", "/users/{user-id}/chats/{chat-id}/pinnedMessages/{pinnedChatMessageInfo-id}")]
    [Cmdlet(VerbsData.Update, "MgUserChatPinnedMessage", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Teams.Client.Models.PinnedChatMessageInfo))]
    public class UpdateMgUserChatPinnedMessageCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ChatId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string PinnedChatMessageInfoId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PinnedChatMessageInfoId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Teams.Client.Models.PinnedChatMessageInfo();




        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Teams.Client.Models.PinnedChatMessageInfo? result;
            try
            {
                result = client.Users[UserId].Chats[ChatId].PinnedMessages[PinnedChatMessageInfoId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, PinnedChatMessageInfoId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Users[UserId].Chats[ChatId].PinnedMessages[PinnedChatMessageInfoId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, PinnedChatMessageInfoId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
