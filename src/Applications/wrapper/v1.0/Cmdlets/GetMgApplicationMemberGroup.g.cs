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
    [GraphRoute("POST", "/applications/{application-id}/getMemberGroups")]
    [Cmdlet(VerbsCommon.Get, "MgApplicationMemberGroup", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Applications.Client.Applications.Item.GetMemberGroups.GetMemberGroupsPostResponse))]
    public class GetMgApplicationMemberGroupCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ApplicationId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? SecurityEnabledOnly { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ApplicationId, "Get"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Applications.Client.Applications.Item.GetMemberGroups.GetMemberGroupsPostRequestBody();

    if (this.IsParameterBound(nameof(SecurityEnabledOnly)))
        body.SecurityEnabledOnly = SecurityEnabledOnly;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.Applications.Client.Applications.Item.GetMemberGroups.GetMemberGroupsPostResponse? result;
            try
            {
                result = client.Applications[ApplicationId].GetMemberGroups.PostAsGetMemberGroupsPostResponseAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, ApplicationId);
                return;
            }

            WriteObject(result);
        }
    }
}
