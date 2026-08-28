#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.PersonalContacts.Client;
using Microsoft.Graph.PowerShell.PersonalContacts.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.PersonalContacts
{
    [GraphRoute("POST", "/users/{user-id}/contactFolders/{contactFolder-id}/childFolders/{contactFolder-id1}/permanentDelete")]
    [Cmdlet(VerbsCommon.Remove, "MgUserContactFolderChildFolderPermanent", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class RemoveMgUserContactFolderChildFolderPermanentCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ContactFolderId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string ContactFolderId1 { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ContactFolderId1, "Remove"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Users[UserId].ContactFolders[ContactFolderId].ChildFolders[ContactFolderId1].PermanentDelete.PostAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, ContactFolderId1);
                return;
            }

        }
    }
}
