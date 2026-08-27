#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.PersonalContacts.Client;
using Microsoft.Graph.PowerShell.PersonalContacts.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.PersonalContacts
{
    [GraphRoute("PATCH", "/users/{user-id}/contactFolders/{contactFolder-id}/contacts/{contact-id}/extensions/{extension-id}")]
    [Cmdlet(VerbsData.Update, "MgUserContactFolderContactExtension", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.PersonalContacts.Client.Models.Extension))]
    public class UpdateMgUserContactFolderContactExtensionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ContactFolderId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string ContactId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string ExtensionId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ExtensionId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.PersonalContacts.Client.Models.Extension();




        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.PersonalContacts.Client.Models.Extension? result;
            try
            {
                result = client.Users[UserId].ContactFolders[ContactFolderId].Contacts[ContactId].Extensions[ExtensionId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, ExtensionId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Users[UserId].ContactFolders[ContactFolderId].Contacts[ContactId].Extensions[ExtensionId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, ExtensionId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
