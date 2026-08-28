#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.PersonalContacts.Client;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.PersonalContacts
{
    [GraphRoute("GET", "/users/{user-id}/contactFolders/{contactFolder-id}/contacts/{contact-id}/extensions/$count")]
    [Cmdlet(VerbsCommon.Get, "MgUserContactFolderContactExtensionCount")]
    [OutputType(typeof(int))]
    public class GetMgUserContactFolderContactExtensionCountCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ContactFolderId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string ContactId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        public string? Filter { get; set; }

        [Parameter(Mandatory = false)]
        public string? Search { get; set; }



        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            int? result;
            try
            {
                result = client.Users[UserId].ContactFolders[ContactFolderId].Contacts[ContactId].Extensions.Count.GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Filter)))
                        requestConfiguration.QueryParameters.Filter = Filter;

                    if (this.IsParameterBound(nameof(Search)))
                        requestConfiguration.QueryParameters.Search = Search;

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, ContactId);
                return;
            }

            if (result is not null)
                WriteObject(result);
        }
    }
}
