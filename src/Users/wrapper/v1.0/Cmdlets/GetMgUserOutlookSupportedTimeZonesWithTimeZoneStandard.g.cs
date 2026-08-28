#nullable enable

using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Users.Client;
using Microsoft.Graph.PowerShell.Users.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Users
{
    [GraphRoute("GET", "/users/{user-id}/outlook/supportedTimeZones(TimeZoneStandard='{TimeZoneStandard}')")]
    [Cmdlet(VerbsCommon.Get, "MgUserOutlookSupportedTimeZonesWithTimeZoneStandard")]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Users.Client.Users.Item.Outlook.SupportedTimeZonesWithTimeZoneStandard.SupportedTimeZonesWithTimeZoneStandardGetResponse))]
    public class GetMgUserOutlookSupportedTimeZonesWithTimeZoneStandardCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;

        [Parameter(Mandatory = true, Position = 1,
            HelpMessage = "Value for the 'TimeZoneStandard' parameter of this OData function.")]
        public string TimeZoneStandard { get; set; } = string.Empty;



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
            { "TimeZoneStandard", TimeZoneStandard },
        };
        var requestBuilder = new global::Microsoft.Graph.PowerShell.Users.Client.Users.Item.Outlook.SupportedTimeZonesWithTimeZoneStandard.SupportedTimeZonesWithTimeZoneStandardRequestBuilder(pathParameters, requestAdapter);

            global::Microsoft.Graph.PowerShell.Users.Client.Users.Item.Outlook.SupportedTimeZonesWithTimeZoneStandard.SupportedTimeZonesWithTimeZoneStandardGetResponse? result;
            try
            {
                result = requestBuilder.GetAsSupportedTimeZonesWithTimeZoneStandardGetResponseAsync(requestConfiguration =>
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
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, UserId);
                return;
            }

            WriteObject(result);
        }
    }
}
