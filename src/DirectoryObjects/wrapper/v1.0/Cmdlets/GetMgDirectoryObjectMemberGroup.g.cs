#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DirectoryObjects.Client;
using Microsoft.Graph.PowerShell.DirectoryObjects.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DirectoryObjects
{
    [GraphRoute("POST", "/directoryObjects/{directoryObject-id}/getMemberGroups")]
    [Cmdlet(VerbsCommon.Get, "MgDirectoryObjectMemberGroup", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.DirectoryObjects.Client.DirectoryObjects.Item.GetMemberGroups.GetMemberGroupsPostResponse))]
    public class GetMgDirectoryObjectMemberGroupCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DirectoryObjectId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? SecurityEnabledOnly { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DirectoryObjectId, "Get"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.DirectoryObjects.Client.DirectoryObjects.Item.GetMemberGroups.GetMemberGroupsPostRequestBody();

    if (this.IsParameterBound(nameof(SecurityEnabledOnly)))
        body.SecurityEnabledOnly = SecurityEnabledOnly;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.DirectoryObjects.Client.DirectoryObjects.Item.GetMemberGroups.GetMemberGroupsPostResponse? result;
            try
            {
                result = client.DirectoryObjects[DirectoryObjectId].GetMemberGroups.PostAsGetMemberGroupsPostResponseAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DirectoryObjectId);
                return;
            }

            WriteObject(result);
        }
    }
}
