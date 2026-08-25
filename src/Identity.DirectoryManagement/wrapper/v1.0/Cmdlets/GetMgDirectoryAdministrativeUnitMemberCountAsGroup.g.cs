#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.DirectoryManagement
{
    [GraphRoute("GET", "/directory/administrativeUnits/{administrativeUnit-id}/members/graph.group/$count")]
    [Cmdlet(VerbsCommon.Get, "MgDirectoryAdministrativeUnitMemberCountAsGroup")]
    [OutputType(typeof(int))]
    public class GetMgDirectoryAdministrativeUnitMemberCountAsGroupCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AdministrativeUnitId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        public string? Filter { get; set; }

        [Parameter(Mandatory = false)]
        public string? Search { get; set; }


        [Parameter(Mandatory = false,
            HelpMessage = "Sets the 'ConsistencyLevel' request header (for example an ETag for optimistic concurrency; some Graph APIs require it even where the spec marks it optional).")]
        public string? ConsistencyLevel { get; set; }


        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            int? result;
            try
            {
                result = client.Directory.AdministrativeUnits[AdministrativeUnitId].Members.GraphGroup.Count.GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Filter)))
                        requestConfiguration.QueryParameters.Filter = Filter;

                    if (this.IsParameterBound(nameof(Search)))
                        requestConfiguration.QueryParameters.Search = Search;

                        if (this.IsParameterBound(nameof(ConsistencyLevel)))
                            requestConfiguration.Headers.Add("ConsistencyLevel", ConsistencyLevel!);

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, AdministrativeUnitId);
                return;
            }

            if (result is not null)
                WriteObject(result);
        }
    }
}
