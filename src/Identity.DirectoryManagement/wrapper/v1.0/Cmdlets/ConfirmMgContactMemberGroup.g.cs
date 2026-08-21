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
    [GraphRoute("POST", "/contacts/{orgContact-id}/checkMemberGroups")]
    [Cmdlet(VerbsLifecycle.Confirm, "MgContactMemberGroup", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Contacts.Item.CheckMemberGroups.CheckMemberGroupsPostResponse))]
    public class ConfirmMgContactMemberGroupCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string OrgContactId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string[]? GroupIds { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(OrgContactId, "Confirm"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Contacts.Item.CheckMemberGroups.CheckMemberGroupsPostRequestBody();

    if (this.IsParameterBound(nameof(GroupIds)))
        body.GroupIds = GroupIds!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Contacts.Item.CheckMemberGroups.CheckMemberGroupsPostResponse? result;
            try
            {
                result = client.Contacts[OrgContactId].CheckMemberGroups.PostAsCheckMemberGroupsPostResponseAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, OrgContactId);
                return;
            }

            WriteObject(result);
        }
    }
}
