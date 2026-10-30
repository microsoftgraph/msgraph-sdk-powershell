#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.WindowsUpdates.Client;
using Microsoft.Graph.PowerShell.WindowsUpdates.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.WindowsUpdates
{
    [GraphRoute("POST", "/admin/windows/updates/deployments/{deployment-id}/audience/microsoft.graph.windowsUpdates.updateAudienceById")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgWindowsUpdatesDeploymentAudienceUpdateAudienceById", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgWindowsUpdatesDeploymentAudienceUpdateAudienceByIdCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeploymentId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? MemberEntityType { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? AddMembers { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? RemoveMembers { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? AddExclusions { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? RemoveExclusions { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeploymentId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.WindowsUpdates.Client.Admin.Windows.Updates.Deployments.Item.Audience.MicrosoftGraphWindowsUpdatesUpdateAudienceById.UpdateAudienceByIdPostRequestBody();

    if (this.IsParameterBound(nameof(MemberEntityType)))
        body.MemberEntityType = MemberEntityType;

    if (this.IsParameterBound(nameof(AddMembers)))
        body.AddMembers = AddMembers!.ToList();

    if (this.IsParameterBound(nameof(RemoveMembers)))
        body.RemoveMembers = RemoveMembers!.ToList();

    if (this.IsParameterBound(nameof(AddExclusions)))
        body.AddExclusions = AddExclusions!.ToList();

    if (this.IsParameterBound(nameof(RemoveExclusions)))
        body.RemoveExclusions = RemoveExclusions!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Admin.Windows.Updates.Deployments[DeploymentId].Audience.MicrosoftGraphWindowsUpdatesUpdateAudienceById.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DeploymentId);
                return;
            }

        }
    }
}
