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
    [GraphRoute("POST", "/directoryRoleTemplates/{directoryRoleTemplate-id}/getMemberObjects")]
    [Cmdlet(VerbsCommon.Get, "MgDirectoryRoleTemplateMemberObject", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.DirectoryRoleTemplates.Item.GetMemberObjects.GetMemberObjectsPostResponse))]
    public class GetMgDirectoryRoleTemplateMemberObjectCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DirectoryRoleTemplateId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? SecurityEnabledOnly { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DirectoryRoleTemplateId, "Get"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.DirectoryRoleTemplates.Item.GetMemberObjects.GetMemberObjectsPostRequestBody();

    if (this.IsParameterBound(nameof(SecurityEnabledOnly)))
        body.SecurityEnabledOnly = SecurityEnabledOnly;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.DirectoryRoleTemplates.Item.GetMemberObjects.GetMemberObjectsPostResponse? result;
            try
            {
                result = client.DirectoryRoleTemplates[DirectoryRoleTemplateId].GetMemberObjects.PostAsGetMemberObjectsPostResponseAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DirectoryRoleTemplateId);
                return;
            }

            WriteObject(result);
        }
    }
}
