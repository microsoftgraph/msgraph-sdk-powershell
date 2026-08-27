#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Notes.Client;
using Microsoft.Graph.PowerShell.Notes.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Notes
{
    [GraphRoute("POST", "/users/{user-id}/onenote/sections/{onenoteSection-id}/pages")]
    [Cmdlet(VerbsCommon.New, "MgUserOnenoteSectionPage", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Notes.Client.Models.OnenotePage))]
    public class NewMgUserOnenoteSectionPageCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string OnenoteSectionId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Self { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public byte[]? Content { get; set; }

        [Parameter(Mandatory = false)]
        public string? ContentUrl { get; set; }

        [Parameter(Mandatory = false)]
        public string? CreatedByAppId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public int? Level { get; set; }

        [Parameter(Mandatory = false)]
        public int? Order { get; set; }

        [Parameter(Mandatory = false)]
        public string? Title { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? UserTags { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Notes.Client.Models.PageLinks? Links { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(OnenoteSectionId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Notes.Client.Models.OnenotePage();

    if (this.IsParameterBound(nameof(Self)))
        body.Self = Self;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(Content)))
        body.Content = Content;

    if (this.IsParameterBound(nameof(ContentUrl)))
        body.ContentUrl = ContentUrl;

    if (this.IsParameterBound(nameof(CreatedByAppId)))
        body.CreatedByAppId = CreatedByAppId;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(Level)))
        body.Level = Level;

    if (this.IsParameterBound(nameof(Order)))
        body.Order = Order;

    if (this.IsParameterBound(nameof(Title)))
        body.Title = Title;

    if (this.IsParameterBound(nameof(UserTags)))
        body.UserTags = UserTags!.ToList();

    if (this.IsParameterBound(nameof(Links)))
        body.Links = Links;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Notes.Client.Models.OnenotePage? result;
            try
            {
                result = client.Users[UserId].Onenote.Sections[OnenoteSectionId].Pages.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
