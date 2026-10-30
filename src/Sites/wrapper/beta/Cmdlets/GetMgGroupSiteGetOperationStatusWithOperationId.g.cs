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
    [GraphRoute("GET", "/groups/{group-id}/sites/getOperationStatus(operationId='{operationId}')")]
    [Cmdlet(VerbsCommon.Get, "MgGroupSiteGetOperationStatusWithOperationId")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Sites.Client.Models.RichLongRunningOperation))]
    public class GetMgGroupSiteGetOperationStatusWithOperationIdCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;

        [Parameter(Mandatory = true, Position = 1,
            HelpMessage = "Value for the 'operationId' parameter of this OData function.")]
        public string OperationId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

        var pathParameters = new Dictionary<string, object>
        {
            { "baseurl", requestAdapter.BaseUrl! },
            { "group%2Did", GroupId },
            { "operationId", OperationId },
        };
        var requestBuilder = new global::Microsoft.Graph.PowerShell.Sites.Client.Groups.Item.Sites.GetOperationStatusWithOperationId.GetOperationStatusWithOperationIdRequestBuilder(pathParameters, requestAdapter);

            Microsoft.Graph.PowerShell.Sites.Client.Models.RichLongRunningOperation? result;
            try
            {
                result = requestBuilder.GetAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, GroupId);
                return;
            }

            WriteObject(result);
        }
    }
}
