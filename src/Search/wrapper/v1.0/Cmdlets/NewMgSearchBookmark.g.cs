#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Search.Client;
using Microsoft.Graph.PowerShell.Search.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Search
{
    [GraphRoute("POST", "/search/bookmarks")]
    [Cmdlet(VerbsCommon.New, "MgSearchBookmark", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Search.Client.Models.Search.Bookmark))]
    public class NewMgSearchBookmarkCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? WebUrl { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? AvailabilityEndDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? AvailabilityStartDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? Categories { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? GroupIds { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsSuggested { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? LanguageTags { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? PowerAppIds { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Search.Client.Models.Search.IdentitySet? LastModifiedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Search.Client.Models.Search.AnswerKeyword? Keywords { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Search.Client.Models.DevicePlatformType?[]? Platforms { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Search.Client.Models.Search.AnswerState? State { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Search.Client.Models.Search.AnswerVariant[]? TargetedVariations { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Search.Client.Models.Search.Bookmark();

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(WebUrl)))
        body.WebUrl = WebUrl;

    if (this.IsParameterBound(nameof(AvailabilityEndDateTime)))
        body.AvailabilityEndDateTime = AvailabilityEndDateTime;

    if (this.IsParameterBound(nameof(AvailabilityStartDateTime)))
        body.AvailabilityStartDateTime = AvailabilityStartDateTime;

    if (this.IsParameterBound(nameof(Categories)))
        body.Categories = Categories!.ToList();

    if (this.IsParameterBound(nameof(GroupIds)))
        body.GroupIds = GroupIds!.ToList();

    if (this.IsParameterBound(nameof(IsSuggested)))
        body.IsSuggested = IsSuggested;

    if (this.IsParameterBound(nameof(LanguageTags)))
        body.LanguageTags = LanguageTags!.ToList();

    if (this.IsParameterBound(nameof(PowerAppIds)))
        body.PowerAppIds = PowerAppIds!.ToList();

    if (this.IsParameterBound(nameof(LastModifiedBy)))
        body.LastModifiedBy = LastModifiedBy;

    if (this.IsParameterBound(nameof(Keywords)))
        body.Keywords = Keywords;

    if (this.IsParameterBound(nameof(Platforms)))
        body.Platforms = Platforms!.ToList();

    if (this.IsParameterBound(nameof(State)))
        body.State = State;

    if (this.IsParameterBound(nameof(TargetedVariations)))
        body.TargetedVariations = TargetedVariations!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Search.Client.Models.Search.Bookmark? result;
            try
            {
                result = client.Search.Bookmarks.PostAsync(body, requestConfiguration =>
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
