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
    [GraphRoute("POST", "/groupLifecyclePolicies")]
    [Cmdlet(VerbsCommon.New, "MgGroupLifecyclePolicy", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Groups.Client.Models.GroupLifecyclePolicy))]
    public class NewMgGroupLifecyclePolicyCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? AlternateNotificationEmails { get; set; }

        [Parameter(Mandatory = false)]
        public int? GroupLifetimeInDays { get; set; }

        [Parameter(Mandatory = false)]
        public string? ManagedGroupTypes { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
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
                result = client.GroupLifecyclePolicies.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
