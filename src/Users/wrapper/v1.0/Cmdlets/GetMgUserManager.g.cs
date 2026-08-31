#nullable enable

using System;
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
    [GraphRoute("GET", "/users/{user-id}/manager")]
    [Cmdlet(VerbsCommon.Get, "MgUserManager")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Users.Client.Models.DirectoryObject))]
    public class GetMgUserManagerCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        [Alias("Select")]
        public string[]? Property { get; set; }
        [Parameter(Mandatory = false)]
        [Alias("Expand")]
        public string[]? ExpandProperty { get; set; }


        [Parameter(Mandatory = false,
            HelpMessage = "Sets the 'ConsistencyLevel' request header (for example an ETag for optimistic concurrency; some Graph APIs require it even where the spec marks it optional).")]
        public string? ConsistencyLevel { get; set; }


        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Users.Client.Models.DirectoryObject? result;
            try
            {
                result = client.Users[UserId].Manager.GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;


        if (this.IsParameterBound(nameof(ConsistencyLevel)))
            requestConfiguration.Headers.Add("ConsistencyLevel", ConsistencyLevel!);


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
