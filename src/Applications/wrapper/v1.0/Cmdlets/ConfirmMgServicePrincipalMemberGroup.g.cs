#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Applications.Client;
using Microsoft.Graph.PowerShell.Applications.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Applications
{
    [GraphRoute("POST", "/servicePrincipals/{servicePrincipal-id}/checkMemberGroups")]
    [Cmdlet(VerbsLifecycle.Confirm, "MgServicePrincipalMemberGroup", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Applications.Client.ServicePrincipals.Item.CheckMemberGroups.CheckMemberGroupsPostResponse))]
    public class ConfirmMgServicePrincipalMemberGroupCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ServicePrincipalId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string[]? GroupIds { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ServicePrincipalId, "Confirm"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Applications.Client.ServicePrincipals.Item.CheckMemberGroups.CheckMemberGroupsPostRequestBody();

    if (this.IsParameterBound(nameof(GroupIds)))
        body.GroupIds = GroupIds!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.Applications.Client.ServicePrincipals.Item.CheckMemberGroups.CheckMemberGroupsPostResponse? result;
            try
            {
                result = client.ServicePrincipals[ServicePrincipalId].CheckMemberGroups.PostAsCheckMemberGroupsPostResponseAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, ServicePrincipalId);
                return;
            }

            WriteObject(result);
        }
    }
}
