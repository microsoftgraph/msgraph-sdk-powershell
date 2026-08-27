#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Notes.Client;
using Microsoft.Graph.PowerShell.Notes.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Notes
{
    [GraphRoute("POST", "/groups/{group-id}/onenote/pages/{onenotePage-id}/copyToSection")]
    [Cmdlet(VerbsCommon.Copy, "MgGroupOnenotePageToSection", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Notes.Client.Models.OnenoteOperation))]
    public class CopyMgGroupOnenotePageToSectionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string OnenotePageId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? GroupId1 { get; set; }

        [Parameter(Mandatory = false)]
        public string? SiteCollectionId { get; set; }

        [Parameter(Mandatory = false)]
        public string? SiteId { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(OnenotePageId, "Copy"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Notes.Client.Groups.Item.Onenote.Pages.Item.CopyToSection.CopyToSectionPostRequestBody();

    if (this.IsParameterBound(nameof(GroupId1)))
        body.GroupId = GroupId1;

    if (this.IsParameterBound(nameof(SiteCollectionId)))
        body.SiteCollectionId = SiteCollectionId;

    if (this.IsParameterBound(nameof(SiteId)))
        body.SiteId = SiteId;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Notes.Client.Models.OnenoteOperation? result;
            try
            {
                result = client.Groups[GroupId].Onenote.Pages[OnenotePageId].CopyToSection.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, OnenotePageId);
                return;
            }

            WriteObject(result);
        }
    }
}
