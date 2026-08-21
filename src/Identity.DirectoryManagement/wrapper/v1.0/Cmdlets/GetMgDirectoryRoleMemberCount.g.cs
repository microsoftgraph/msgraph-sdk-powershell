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
    [GraphRoute("GET", "/directoryRoles/{directoryRole-id}/members/$count")]
    [Cmdlet(VerbsCommon.Get, "MgDirectoryRoleMemberCount")]
    [OutputType(typeof(int))]
    public class GetMgDirectoryRoleMemberCountCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DirectoryRoleId { get; set; } = string.Empty;



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
                result = client.DirectoryRoles[DirectoryRoleId].Members.Count.GetAsync(requestConfiguration =>
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
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, DirectoryRoleId);
                return;
            }

            if (result is not null)
                WriteObject(result);
        }
    }
}
