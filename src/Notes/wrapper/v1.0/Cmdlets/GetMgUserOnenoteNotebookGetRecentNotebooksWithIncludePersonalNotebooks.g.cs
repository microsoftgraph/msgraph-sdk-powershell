#nullable enable

using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Notes.Client;
using Microsoft.Graph.PowerShell.Notes.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Notes
{
    [GraphRoute("GET", "/users/{user-id}/onenote/notebooks/getRecentNotebooks(includePersonalNotebooks={includePersonalNotebooks})")]
    [Cmdlet(VerbsCommon.Get, "MgUserOnenoteNotebookGetRecentNotebooksWithIncludePersonalNotebooks")]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Notes.Client.Users.Item.Onenote.Notebooks.GetRecentNotebooksWithIncludePersonalNotebooks.GetRecentNotebooksWithIncludePersonalNotebooksGetResponse))]
    public class GetMgUserOnenoteNotebookGetRecentNotebooksWithIncludePersonalNotebooksCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;

        [Parameter(Mandatory = true, Position = 1,
            HelpMessage = "Value for the 'includePersonalNotebooks' parameter of this OData function.")]
        public string IncludePersonalNotebooks { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        public string? Filter { get; set; }

        [Parameter(Mandatory = false)]
        public string? Search { get; set; }

        [Parameter(Mandatory = false)]
        public int Top { get; set; }

        [Parameter(Mandatory = false)]
        public int Skip { get; set; }

        [Parameter(Mandatory = false)]
        public SwitchParameter Count { get; set; }




        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

        var pathParameters = new Dictionary<string, object>
        {
            { "baseurl", requestAdapter.BaseUrl! },
            { "user%2Did", UserId },
            { "includePersonalNotebooks", IncludePersonalNotebooks },
        };
        var requestBuilder = new global::Microsoft.Graph.PowerShell.Notes.Client.Users.Item.Onenote.Notebooks.GetRecentNotebooksWithIncludePersonalNotebooks.GetRecentNotebooksWithIncludePersonalNotebooksRequestBuilder(pathParameters, requestAdapter);

            global::Microsoft.Graph.PowerShell.Notes.Client.Users.Item.Onenote.Notebooks.GetRecentNotebooksWithIncludePersonalNotebooks.GetRecentNotebooksWithIncludePersonalNotebooksGetResponse? result;
            try
            {
                result = requestBuilder.GetAsGetRecentNotebooksWithIncludePersonalNotebooksGetResponseAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Filter)))
                        requestConfiguration.QueryParameters.Filter = Filter;

                    if (this.IsParameterBound(nameof(Search)))
                        requestConfiguration.QueryParameters.Search = Search;

                    if (this.IsParameterBound(nameof(Top)))
                        requestConfiguration.QueryParameters.Top = Top;

                    if (this.IsParameterBound(nameof(Skip)))
                        requestConfiguration.QueryParameters.Skip = Skip;

                    if (Count.IsPresent)
                        requestConfiguration.QueryParameters.Count = true;

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, UserId);
                return;
            }

            WriteObject(result);
        }
    }
}
