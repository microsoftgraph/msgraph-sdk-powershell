#nullable enable

using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Calendar.Client;
using Microsoft.Graph.PowerShell.Calendar.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Calendar
{
    [GraphRoute("GET", "/places/getOperation(id='{id}')")]
    [Cmdlet(VerbsCommon.Get, "MgPlaceGetOperationWithId")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Calendar.Client.Models.PlaceOperation))]
    public class GetMgPlaceGetOperationWithIdCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = true, Position = 0,
            HelpMessage = "Value for the 'id' parameter of this OData function.")]
        public string Id { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

        var pathParameters = new Dictionary<string, object>
        {
            { "baseurl", requestAdapter.BaseUrl! },
            { "id", Id },
        };
        var requestBuilder = new global::Microsoft.Graph.PowerShell.Calendar.Client.Places.GetOperationWithId.GetOperationWithIdRequestBuilder(pathParameters, requestAdapter);

            Microsoft.Graph.PowerShell.Calendar.Client.Models.PlaceOperation? result;
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
