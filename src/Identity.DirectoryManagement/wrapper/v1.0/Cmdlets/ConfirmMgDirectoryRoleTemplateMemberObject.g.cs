#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.DirectoryManagement
{
    [GraphRoute("POST", "/directoryRoleTemplates/{directoryRoleTemplate-id}/checkMemberObjects")]
    [Cmdlet(VerbsLifecycle.Confirm, "MgDirectoryRoleTemplateMemberObject", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.DirectoryRoleTemplates.Item.CheckMemberObjects.CheckMemberObjectsPostResponse))]
    public class ConfirmMgDirectoryRoleTemplateMemberObjectCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DirectoryRoleTemplateId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string[]? Ids { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DirectoryRoleTemplateId, "Confirm"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.DirectoryRoleTemplates.Item.CheckMemberObjects.CheckMemberObjectsPostRequestBody();

    if (this.IsParameterBound(nameof(Ids)))
        body.Ids = Ids!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.DirectoryRoleTemplates.Item.CheckMemberObjects.CheckMemberObjectsPostResponse? result;
            try
            {
                result = client.DirectoryRoleTemplates[DirectoryRoleTemplateId].CheckMemberObjects.PostAsCheckMemberObjectsPostResponseAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, DirectoryRoleTemplateId);
                return;
            }

            WriteObject(result);
        }
    }
}
