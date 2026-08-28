#nullable enable

using System;
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
    [GraphRoute("GET", "/shares/{sharedDriveItem-id}/items")]
    [Cmdlet(VerbsCommon.Get, "MgShareItem_List")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.DriveItem))]
    public class GetMgShareItem_ListCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SharedDriveItemId { get; set; } = string.Empty;



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

        // Follows every @odata.nextLink until the collection is exhausted (a bound -Top caps
        // the total). Without it only the first page returns, plus a truncation warning when
        // more pages existed.
        [Parameter(Mandatory = false)]
        public SwitchParameter All { get; set; }



        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Files.Client.Models.DriveItemCollectionResponse? result;
            try
            {
                result = client.Shares[SharedDriveItemId].Items.GetAsync(requestConfiguration =>
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

                // A collection response and its Value are both nullable on the kiota client; an
                // empty page writes nothing rather than dereferencing null. Each page streams to
                // the pipeline before the next request is issued, matching the published SDK.
                if (result?.Value is { } items)
                    WriteObject(items, enumerateCollection: true);

                if (All.IsPresent)
                {
                    var fetched = result?.Value?.Count ?? 0;
                    var nextLink = result?.OdataNextLink;
                    while (!string.IsNullOrEmpty(nextLink) && !Stopping && (!this.IsParameterBound(nameof(Top)) || fetched < Top))
                    {
                        // The nextLink already carries the original query state, and a raw-URL
                        // builder ignores templated query parameters anyway - so the continuation
                        // re-applies headers only; query bindings here would be dead code.
                        result = client.Shares[SharedDriveItemId].Items.WithUrl(nextLink).GetAsync(requestConfiguration =>
                        {

                AddRequestHeaders(requestConfiguration.Headers);
                        }).GetAwaiter().GetResult();
                        if (result?.Value is { } page)
                        {
                            WriteObject(page, enumerateCollection: true);
                            fetched += page.Count;
                        }
                        nextLink = result?.OdataNextLink;
                    }
                }
                else if (!string.IsNullOrEmpty(result?.OdataNextLink))
                {
                    // Deliberately stronger than the published SDK, which truncates silently;
                    // approved in the design spec. One line, no extra request.
                    WriteWarning("More results are available. Use -All to return all pages.");
                }
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, SharedDriveItemId);
                return;
            }
        }
    }
}
