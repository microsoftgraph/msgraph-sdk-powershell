#nullable enable

using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.NetworkAccess.Client;
using Microsoft.Graph.PowerShell.NetworkAccess.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.NetworkAccess
{
    [GraphRoute("GET", "/networkAccess/connectivity/microsoft.graph.networkaccess.getWebCategoryByUrl(url='{url}')")]
    [Cmdlet(VerbsCommon.Get, "MgNetworkAccessConnectivityGetWebCategoryByUrlWithUrl")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.WebCategory))]
    public class GetMgNetworkAccessConnectivityGetWebCategoryByUrlWithUrlCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = true, Position = 0,
            HelpMessage = "Value for the 'url' parameter of this OData function.")]
        public string Url { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

        var pathParameters = new Dictionary<string, object>
        {
            { "baseurl", requestAdapter.BaseUrl! },
            { "url", Url },
        };
        var requestBuilder = new global::Microsoft.Graph.PowerShell.NetworkAccess.Client.NetworkAccess.Connectivity.MicrosoftGraphNetworkaccessGetWebCategoryByUrlWithUrl.MicrosoftGraphNetworkaccessGetWebCategoryByUrlWithUrlRequestBuilder(pathParameters, requestAdapter);

            Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.WebCategory? result;
            try
            {
                result = requestBuilder.GetAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }

            WriteObject(result);
        }
    }
}
