#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.NetworkAccess.Client;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.NetworkAccess
{
    [GraphRoute("GET", "/networkAccess/logs/traffic/{networkAccessTraffic-transactionId}/user/serviceProvisioningErrors/$count")]
    [Cmdlet(VerbsCommon.Get, "MgNetworkAccessLogTrafficUserServiceProvisioningErrorCount")]
    [OutputType(typeof(int))]
    public class GetMgNetworkAccessLogTrafficUserServiceProvisioningErrorCountCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string NetworkAccessTrafficTransactionId { get; set; } = string.Empty;



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
                result = client.NetworkAccess.Logs.Traffic[NetworkAccessTrafficTransactionId].User.ServiceProvisioningErrors.Count.GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Filter)))
                        requestConfiguration.QueryParameters.Filter = Filter;

                    if (this.IsParameterBound(nameof(Search)))
                        requestConfiguration.QueryParameters.Search = Search;

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, NetworkAccessTrafficTransactionId);
                return;
            }

            if (result is not null)
                WriteObject(result);
        }
    }
}
