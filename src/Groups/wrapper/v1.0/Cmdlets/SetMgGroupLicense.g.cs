#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Groups.Client;
using Microsoft.Graph.PowerShell.Groups.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Groups
{
    [GraphRoute("POST", "/groups/{group-id}/assignLicense")]
    [Cmdlet(VerbsCommon.Set, "MgGroupLicense", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Groups.Client.Models.Group))]
    public class SetMgGroupLicenseCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.Guid?[]? RemoveLicenses { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Groups.Client.Models.AssignedLicense[]? AddLicenses { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(GroupId, "Set"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Groups.Client.Groups.Item.AssignLicense.AssignLicensePostRequestBody();

    if (this.IsParameterBound(nameof(RemoveLicenses)))
        body.RemoveLicenses = RemoveLicenses!.ToList();
    if (this.IsParameterBound(nameof(AddLicenses)))
        body.AddLicenses = AddLicenses!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Groups.Client.Models.Group? result;
            try
            {
                result = client.Groups[GroupId].AssignLicense.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, GroupId);
                return;
            }

            WriteObject(result);
        }
    }
}
