#nullable enable

using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Files.Client;
using Microsoft.Graph.PowerShell.Files.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Files
{
    [GraphRoute("GET", "/drives/{drive-id}/list/items/{listItem-id}/getActivitiesByInterval(startDateTime='{startDateTime}',endDateTime='{endDateTime}',interval='{interval}')")]
    [Cmdlet(VerbsCommon.Get, "MgDriveListItemGetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval")]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Files.Client.Drives.Item.List.Items.Item.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithIntervalGetResponse))]
    public class GetMgDriveListItemGetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithIntervalCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ListItemId { get; set; } = string.Empty;

        [Parameter(Mandatory = true, Position = 2,
            HelpMessage = "Value for the 'startDateTime' parameter of this OData function.")]
        public string StartDateTime { get; set; } = string.Empty;

        [Parameter(Mandatory = true, Position = 3,
            HelpMessage = "Value for the 'endDateTime' parameter of this OData function.")]
        public string EndDateTime { get; set; } = string.Empty;

        [Parameter(Mandatory = true, Position = 4,
            HelpMessage = "Value for the 'interval' parameter of this OData function.")]
        public string Interval { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        public string? Filter { get; set; }

        [Parameter(Mandatory = false)]
        [Alias("Select")]
        public string[]? Property { get; set; }

        [Parameter(Mandatory = false)]
        [Alias("Expand")]
        public string[]? ExpandProperty { get; set; }

        [Parameter(Mandatory = false)]
        [Alias("OrderBy")]
        public string[]? Sort { get; set; }

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
            { "drive%2Did", DriveId },
            { "listItem%2Did", ListItemId },
            { "startDateTime", StartDateTime },
            { "endDateTime", EndDateTime },
            { "interval", Interval },
        };
        var requestBuilder = new global::Microsoft.Graph.PowerShell.Files.Client.Drives.Item.List.Items.Item.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithIntervalRequestBuilder(pathParameters, requestAdapter);

            global::Microsoft.Graph.PowerShell.Files.Client.Drives.Item.List.Items.Item.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithInterval.GetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithIntervalGetResponse? result;
            try
            {
                result = requestBuilder.GetAsGetActivitiesByIntervalWithStartDateTimeWithEndDateTimeWithIntervalGetResponseAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Filter)))
                        requestConfiguration.QueryParameters.Filter = Filter;

                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;

                    if (this.IsParameterBound(nameof(Sort)))
                        requestConfiguration.QueryParameters.Orderby = Sort;

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
                ThrowGraphRequestFailed(ex, ListItemId);
                return;
            }

            WriteObject(result);
        }
    }
}
