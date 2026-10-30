#nullable enable

using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Education.Client;
using Microsoft.Graph.PowerShell.Education.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Education
{
    [GraphRoute("GET", "/education/classes/{educationClass-id}/assignments/delta()")]
    [Cmdlet(VerbsCommon.Get, "MgEducationClassAssignmentDelta", DefaultParameterSetName = "DeltaSync")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Education.Client.Models.EducationAssignment))]
    public class GetMgEducationClassAssignmentDeltaCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0, ParameterSetName = "DeltaSync")]
        public string EducationClassId { get; set; } = string.Empty;



        [Parameter(Mandatory = false, ParameterSetName = "DeltaSync")]
        public string? Filter { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "DeltaSync")]
        [Alias("Select")]
        public string[]? Property { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "DeltaSync")]
        [Alias("Expand")]
        public string[]? ExpandProperty { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "DeltaSync")]
        [Alias("OrderBy")]
        public string[]? Sort { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "DeltaSync")]
        public string? Search { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "DeltaSync")]
        public int Top { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "DeltaSync")]
        public int Skip { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "DeltaSync")]
        public SwitchParameter Count { get; set; }

        // Resumes a previous sync from the link that run published. Universal: every delta
        // request builder accepts a raw URL, whereas a token argument exists on only a few.
        [Parameter(Mandatory = true, ParameterSetName = "Resume")]
        public string DeltaLink { get; set; } = string.Empty;

        // Follows @odata.nextLink through the change set. Without it only the first page returns,
        // plus a warning when more pages exist.
        [Parameter(Mandatory = false)]
        public SwitchParameter All { get; set; }

        // Receives the @odata.deltaLink that terminates the change set, for the next sync round.
        // A named variable is how this SDK already returns a scalar alongside a pipeline
        // (-CountVariable on the published list cmdlets).
        [Parameter(Mandatory = false)]
        [Alias("DLV")]
        public string? DeltaLinkVariable { get; set; }



        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            // Cleared before the request so a failed or interrupted run cannot leave the previous
            // run's link readable, which would silently resume from the wrong point.
            if (this.IsParameterBound(nameof(DeltaLinkVariable)))
                SessionState.PSVariable.Set(DeltaLinkVariable, null);

            global::Microsoft.Graph.PowerShell.Education.Client.Education.Classes.Item.Assignments.Delta.DeltaGetResponse? result;
            try
            {
                result = ParameterSetName == "Resume"
                    ? client.Education.Classes[EducationClassId].Assignments.Delta.WithUrl(ValidateContinuationUrl(DeltaLink!, requestAdapter, nameof(DeltaLink))).GetAsDeltaGetResponseAsync(requestConfiguration =>
                        {

                AddRequestHeaders(requestConfiguration.Headers);
                        }).GetAwaiter().GetResult()
                    : client.Education.Classes[EducationClassId].Assignments.Delta.GetAsDeltaGetResponseAsync(requestConfiguration =>
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

                var fetched = 0;
                while (true)
                {
                    if (result?.Value is { } items)
                    {
                        WriteObject(items, enumerateCollection: true);
                        fetched += items.Count;
                    }

                    var nextLink = result?.OdataNextLink;
                    var deltaLink = result?.OdataDeltaLink;

                    // A response cannot be both continued and terminated; treating one as
                    // authoritative would silently drop pages or resume from a partial set.
                    if (!string.IsNullOrEmpty(nextLink) && !string.IsNullOrEmpty(deltaLink))
                    {
                        ThrowTerminatingError(new ErrorRecord(
                            new InvalidOperationException("The response carries both @odata.nextLink and @odata.deltaLink, which is not a valid delta response."),
                            "InvalidDeltaResponse", ErrorCategory.InvalidData, targetObject: null));
                        return;
                    }

                    if (!string.IsNullOrEmpty(deltaLink))
                    {
                        if (this.IsParameterBound(nameof(DeltaLinkVariable)))
                            SessionState.PSVariable.Set(DeltaLinkVariable, deltaLink);
                        break;
                    }

                    // No link of either kind: the change set ends here and there is nothing to
                    // publish for a next round.
                    if (string.IsNullOrEmpty(nextLink)) break;

                    if (!All.IsPresent)
                    {
                        WriteWarning("More results are available. Use -All to return all pages.");
                        break;
                    }

                    if (Stopping) break;
                    if (this.IsParameterBound(nameof(Top)) && fetched >= Top) break;

                    result = client.Education.Classes[EducationClassId].Assignments.Delta.WithUrl(nextLink).GetAsDeltaGetResponseAsync(requestConfiguration =>
                    {

                AddRequestHeaders(requestConfiguration.Headers);
                    }).GetAwaiter().GetResult();
                }
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, EducationClassId);
                return;
            }
        }
    }
}
