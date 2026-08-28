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
    [GraphRoute("POST", "/applications/{application-id}/getMemberObjects")]
    [Cmdlet(VerbsCommon.Get, "MgApplicationMemberObject", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Applications.Client.Applications.Item.GetMemberObjects.GetMemberObjectsPostResponse))]
    public class GetMgApplicationMemberObjectCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ApplicationId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? SecurityEnabledOnly { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ApplicationId, "Get"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Applications.Client.Applications.Item.GetMemberObjects.GetMemberObjectsPostRequestBody();

    if (this.IsParameterBound(nameof(SecurityEnabledOnly)))
        body.SecurityEnabledOnly = SecurityEnabledOnly;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.Applications.Client.Applications.Item.GetMemberObjects.GetMemberObjectsPostResponse? result;
            try
            {
                result = client.Applications[ApplicationId].GetMemberObjects.PostAsGetMemberObjectsPostResponseAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ApplicationId);
                return;
            }

            WriteObject(result);
        }
    }
}
