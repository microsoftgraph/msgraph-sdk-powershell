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
    [GraphRoute("POST", "/contacts/{orgContact-id}/checkMemberObjects")]
    [Cmdlet(VerbsLifecycle.Confirm, "MgContactMemberObject", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Contacts.Item.CheckMemberObjects.CheckMemberObjectsPostResponse))]
    public class ConfirmMgContactMemberObjectCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string OrgContactId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string[]? Ids { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(OrgContactId, "Confirm"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Contacts.Item.CheckMemberObjects.CheckMemberObjectsPostRequestBody();

    if (this.IsParameterBound(nameof(Ids)))
        body.Ids = Ids!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Contacts.Item.CheckMemberObjects.CheckMemberObjectsPostResponse? result;
            try
            {
                result = client.Contacts[OrgContactId].CheckMemberObjects.PostAsCheckMemberObjectsPostResponseAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, OrgContactId);
                return;
            }

            WriteObject(result);
        }
    }
}
