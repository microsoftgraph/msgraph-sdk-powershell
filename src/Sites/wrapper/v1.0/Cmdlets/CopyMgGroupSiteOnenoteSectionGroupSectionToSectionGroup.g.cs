#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Sites.Client;
using Microsoft.Graph.PowerShell.Sites.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Sites
{
    [GraphRoute("POST", "/groups/{group-id}/sites/{site-id}/onenote/sectionGroups/{sectionGroup-id}/sections/{onenoteSection-id}/copyToSectionGroup")]
    [Cmdlet(VerbsCommon.Copy, "MgGroupSiteOnenoteSectionGroupSectionToSectionGroup", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Sites.Client.Models.OnenoteOperation))]
    public class CopyMgGroupSiteOnenoteSectionGroupSectionToSectionGroupCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SiteId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string SectionGroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string OnenoteSectionId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? GroupId1 { get; set; }

        [Parameter(Mandatory = false)]
        public string? RenameAs { get; set; }

        [Parameter(Mandatory = false)]
        public string? SiteCollectionId { get; set; }

        [Parameter(Mandatory = false)]
        public string? SiteId1 { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(OnenoteSectionId, "Copy"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Sites.Client.Groups.Item.Sites.Item.Onenote.SectionGroups.Item.Sections.Item.CopyToSectionGroup.CopyToSectionGroupPostRequestBody();

    if (this.IsParameterBound(nameof(GroupId1)))
        body.GroupId = GroupId1;

    if (this.IsParameterBound(nameof(RenameAs)))
        body.RenameAs = RenameAs;

    if (this.IsParameterBound(nameof(SiteCollectionId)))
        body.SiteCollectionId = SiteCollectionId;

    if (this.IsParameterBound(nameof(SiteId1)))
        body.SiteId = SiteId1;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Sites.Client.Models.OnenoteOperation? result;
            try
            {
                result = client.Groups[GroupId].Sites[SiteId].Onenote.SectionGroups[SectionGroupId].Sections[OnenoteSectionId].CopyToSectionGroup.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, OnenoteSectionId);
                return;
            }

            WriteObject(result);
        }
    }
}
