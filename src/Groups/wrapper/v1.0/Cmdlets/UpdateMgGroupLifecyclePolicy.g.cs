#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Groups.Client;
using Microsoft.Graph.PowerShell.Groups.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Groups
{
    [GraphRoute("PATCH", "/groupLifecyclePolicies/{groupLifecyclePolicy-id}")]
    [Cmdlet(VerbsData.Update, "MgGroupLifecyclePolicy", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Groups.Client.Models.GroupLifecyclePolicy))]
    public class UpdateMgGroupLifecyclePolicyCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupLifecyclePolicyId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? AlternateNotificationEmails { get; set; }

        [Parameter(Mandatory = false)]
        public int? GroupLifetimeInDays { get; set; }

        [Parameter(Mandatory = false)]
        public string? ManagedGroupTypes { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(GroupLifecyclePolicyId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Groups.Client.Models.GroupLifecyclePolicy();

    if (this.IsParameterBound(nameof(AlternateNotificationEmails)))
        body.AlternateNotificationEmails = AlternateNotificationEmails;

    if (this.IsParameterBound(nameof(GroupLifetimeInDays)))
        body.GroupLifetimeInDays = GroupLifetimeInDays;

    if (this.IsParameterBound(nameof(ManagedGroupTypes)))
        body.ManagedGroupTypes = ManagedGroupTypes;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Groups.Client.Models.GroupLifecyclePolicy? result;
            try
            {
                result = client.GroupLifecyclePolicies[GroupLifecyclePolicyId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, GroupLifecyclePolicyId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.GroupLifecyclePolicies[GroupLifecyclePolicyId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, GroupLifecyclePolicyId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
