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
    [GraphRoute("POST", "/users/{user-id}/contactFolders/{contactFolder-id}/childFolders/{contactFolder-id1}/contacts/{contact-id}/extensions")]
    [Cmdlet(VerbsCommon.New, "MgUserContactFolderChildFolderContactExtension", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.PersonalContacts.Client.Models.Extension))]
    public class NewMgUserContactFolderChildFolderContactExtensionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ContactFolderId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string ContactFolderId1 { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string ContactId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ContactId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.PersonalContacts.Client.Models.Extension();




        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.PersonalContacts.Client.Models.Extension? result;
            try
            {
                result = client.Users[UserId].ContactFolders[ContactFolderId].ChildFolders[ContactFolderId1].Contacts[ContactId].Extensions.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
