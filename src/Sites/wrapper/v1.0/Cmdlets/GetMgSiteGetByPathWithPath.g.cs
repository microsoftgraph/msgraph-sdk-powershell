#nullable enable

using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Sites.Client;
using Microsoft.Graph.PowerShell.Sites.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Sites
{
    [GraphRoute("GET", "/sites/{site-id}/getByPath(path='{path}')")]
    [Cmdlet(VerbsCommon.Get, "MgSiteGetByPathWithPath")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Sites.Client.Models.Site))]
    public class GetMgSiteGetByPathWithPathCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SiteId { get; set; } = string.Empty;

        [Parameter(Mandatory = true, Position = 1,
            HelpMessage = "Value for the 'path' parameter of this OData function.")]
        public string Path { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

        var pathParameters = new Dictionary<string, object>
        {
            { "baseurl", requestAdapter.BaseUrl! },
            { "site%2Did", SiteId },
            { "path", Path },
        };
        var requestBuilder = new global::Microsoft.Graph.PowerShell.Sites.Client.Sites.Item.GetByPathWithPath.GetByPathWithPathRequestBuilder(pathParameters, requestAdapter);

            Microsoft.Graph.PowerShell.Sites.Client.Models.Site? result;
            try
            {
                result = requestBuilder.GetAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, SiteId);
                return;
            }

            WriteObject(result);
        }
    }
}
