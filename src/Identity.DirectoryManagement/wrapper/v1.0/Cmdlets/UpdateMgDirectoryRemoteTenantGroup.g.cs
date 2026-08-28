#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.DirectoryManagement
{
    [GraphRoute("PATCH", "/directory/remoteTenantGroups/{remoteTenantGroup-id}")]
    [Cmdlet(VerbsData.Update, "MgDirectoryRemoteTenantGroup", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.RemoteTenantGroup))]
    public class UpdateMgDirectoryRemoteTenantGroupCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string RemoteTenantGroupId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? DeletedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? RemoteGroupDisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.Guid? RemoteGroupId { get; set; }

        [Parameter(Mandatory = false)]
        public string? RemoteTenantDisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.Guid? RemoteTenantId { get; set; }

        [Parameter(Mandatory = false)]
        public string? RemoteTenantPrimaryDomain { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(RemoteTenantGroupId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.RemoteTenantGroup();

    if (this.IsParameterBound(nameof(DeletedDateTime)))
        body.DeletedDateTime = DeletedDateTime;

    if (this.IsParameterBound(nameof(RemoteGroupDisplayName)))
        body.RemoteGroupDisplayName = RemoteGroupDisplayName;

    if (this.IsParameterBound(nameof(RemoteGroupId)))
        body.RemoteGroupId = RemoteGroupId;

    if (this.IsParameterBound(nameof(RemoteTenantDisplayName)))
        body.RemoteTenantDisplayName = RemoteTenantDisplayName;

    if (this.IsParameterBound(nameof(RemoteTenantId)))
        body.RemoteTenantId = RemoteTenantId;

    if (this.IsParameterBound(nameof(RemoteTenantPrimaryDomain)))
        body.RemoteTenantPrimaryDomain = RemoteTenantPrimaryDomain;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.RemoteTenantGroup? result;
            try
            {
                result = client.Directory.RemoteTenantGroups[RemoteTenantGroupId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, RemoteTenantGroupId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Directory.RemoteTenantGroups[RemoteTenantGroupId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, RemoteTenantGroupId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
