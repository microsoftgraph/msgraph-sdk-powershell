#nullable enable

using System;
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
    [GraphRoute("GET", "/groups/{group-id}/sites/{site-id}/lists/{list-id}/columns/{columnDefinition-id}/sourceColumn")]
    [Cmdlet(VerbsCommon.Get, "MgGroupSiteListColumnSourceColumn")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Sites.Client.Models.ColumnDefinition))]
    public class GetMgGroupSiteListColumnSourceColumnCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SiteId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string ListId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string ColumnDefinitionId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        [Alias("Select")]
        public string[]? Property { get; set; }
        [Parameter(Mandatory = false)]
        [Alias("Expand")]
        public string[]? ExpandProperty { get; set; }



        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Sites.Client.Models.ColumnDefinition? result;
            try
            {
                result = client.Groups[GroupId].Sites[SiteId].Lists[ListId].Columns[ColumnDefinitionId].SourceColumn.GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;



        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, ColumnDefinitionId);
                return;
            }

            WriteObject(result);
        }
    }
}
