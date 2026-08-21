#nullable enable

using System;
using System.Collections.Generic;
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
    [GraphRoute("GET", "/groups/{group-id}/sites/{site-id}/contentTypes/{contentType-id}/isPublished()")]
    [Cmdlet(VerbsDiagnostic.Test, "MgGroupSiteContentTypePublished")]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Sites.Client.Groups.Item.Sites.Item.ContentTypes.Item.IsPublished.IsPublishedGetResponse))]
    public class TestMgGroupSiteContentTypePublishedCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SiteId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string ContentTypeId { get; set; } = string.Empty;









        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            global::Microsoft.Graph.PowerShell.Sites.Client.Groups.Item.Sites.Item.ContentTypes.Item.IsPublished.IsPublishedGetResponse? result;
            try
            {
                result = client.Groups[GroupId].Sites[SiteId].ContentTypes[ContentTypeId].IsPublished.GetAsIsPublishedGetResponseAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, ContentTypeId);
                return;
            }

            WriteObject(result);
        }
    }
}
