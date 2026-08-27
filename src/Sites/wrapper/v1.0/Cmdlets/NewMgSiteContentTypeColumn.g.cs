#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.PowerShell.Authentication.Helpers;
using Microsoft.Graph.PowerShell.Sites.Client;
using Microsoft.Graph.PowerShell.Sites.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Sites
{
    [GraphRoute("POST", "/sites/{site-id}/contentTypes/{contentType-id}/columns")]
    [Cmdlet(VerbsCommon.New, "MgSiteContentTypeColumn", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Sites.Client.Models.ColumnDefinition))]
    public class NewMgSiteContentTypeColumnCommand : PSCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SiteId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ContentTypeId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? ColumnGroup { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public bool? EnforceUniqueValues { get; set; }

        [Parameter(Mandatory = false)]
        public bool? Hidden { get; set; }

        [Parameter(Mandatory = false)]
        public bool? Indexed { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsDeletable { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsReorderable { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsSealed { get; set; }

        [Parameter(Mandatory = false)]
        public string? Name { get; set; }

        [Parameter(Mandatory = false)]
        public bool? PropagateChanges { get; set; }

        [Parameter(Mandatory = false)]
        public bool? ReadOnly { get; set; }

        [Parameter(Mandatory = false)]
        public bool? Required { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.BooleanColumn? Boolean { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.CalculatedColumn? Calculated { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.ChoiceColumn? Choice { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.ContentApprovalStatusColumn? ContentApprovalStatus { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.CurrencyColumn? Currency { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.DateTimeColumn? DateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.DefaultColumnValue? DefaultValue { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.GeolocationColumn? Geolocation { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.HyperlinkOrPictureColumn? HyperlinkOrPicture { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.LookupColumn? Lookup { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.NumberColumn? Number { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.PersonOrGroupColumn? PersonOrGroup { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.ContentTypeInfo? SourceContentType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.TermColumn? Term { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.TextColumn? Text { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.ThumbnailColumn? Thumbnail { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.ColumnTypes? Type { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.ColumnValidation? Validation { get; set; }




        [Parameter(Mandatory = false,
            HelpMessage = "Additional HTTP request headers to send, keyed by header name.")]
        public System.Collections.IDictionary? Headers { get; set; }

        [Parameter(Mandatory = false,
            HelpMessage = "Bearer access token. Omit if you have already run Connect-MgGraph.")]
        public string? AccessToken { get; set; }

        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ContentTypeId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Sites.Client.Models.ColumnDefinition();

    if (this.IsParameterBound(nameof(ColumnGroup)))
        body.ColumnGroup = ColumnGroup;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(EnforceUniqueValues)))
        body.EnforceUniqueValues = EnforceUniqueValues;

    if (this.IsParameterBound(nameof(Hidden)))
        body.Hidden = Hidden;

    if (this.IsParameterBound(nameof(Indexed)))
        body.Indexed = Indexed;

    if (this.IsParameterBound(nameof(IsDeletable)))
        body.IsDeletable = IsDeletable;

    if (this.IsParameterBound(nameof(IsReorderable)))
        body.IsReorderable = IsReorderable;

    if (this.IsParameterBound(nameof(IsSealed)))
        body.IsSealed = IsSealed;

    if (this.IsParameterBound(nameof(Name)))
        body.Name = Name;

    if (this.IsParameterBound(nameof(PropagateChanges)))
        body.PropagateChanges = PropagateChanges;

    if (this.IsParameterBound(nameof(ReadOnly)))
        body.ReadOnly = ReadOnly;

    if (this.IsParameterBound(nameof(Required)))
        body.Required = Required;

    if (this.IsParameterBound(nameof(Boolean)))
        body.Boolean = Boolean;

    if (this.IsParameterBound(nameof(Calculated)))
        body.Calculated = Calculated;

    if (this.IsParameterBound(nameof(Choice)))
        body.Choice = Choice;

    if (this.IsParameterBound(nameof(ContentApprovalStatus)))
        body.ContentApprovalStatus = ContentApprovalStatus;

    if (this.IsParameterBound(nameof(Currency)))
        body.Currency = Currency;

    if (this.IsParameterBound(nameof(DateTime)))
        body.DateTime = DateTime;

    if (this.IsParameterBound(nameof(DefaultValue)))
        body.DefaultValue = DefaultValue;

    if (this.IsParameterBound(nameof(Geolocation)))
        body.Geolocation = Geolocation;

    if (this.IsParameterBound(nameof(HyperlinkOrPicture)))
        body.HyperlinkOrPicture = HyperlinkOrPicture;

    if (this.IsParameterBound(nameof(Lookup)))
        body.Lookup = Lookup;

    if (this.IsParameterBound(nameof(Number)))
        body.Number = Number;

    if (this.IsParameterBound(nameof(PersonOrGroup)))
        body.PersonOrGroup = PersonOrGroup;

    if (this.IsParameterBound(nameof(SourceContentType)))
        body.SourceContentType = SourceContentType;

    if (this.IsParameterBound(nameof(Term)))
        body.Term = Term;

    if (this.IsParameterBound(nameof(Text)))
        body.Text = Text;

    if (this.IsParameterBound(nameof(Thumbnail)))
        body.Thumbnail = Thumbnail;

    if (this.IsParameterBound(nameof(Type)))
        body.Type = Type;

    if (this.IsParameterBound(nameof(Validation)))
        body.Validation = Validation;


        // ── Choose HttpClient + auth provider ─────────────────────────────
        HttpClient httpClient;
        IAuthenticationProvider authProvider;

        if (this.IsParameterBound(nameof(AccessToken)))
        {
            httpClient = new HttpClient();
            authProvider = new StaticBearerTokenAuthenticationProvider(AccessToken!);
        }
        else
        {
            WriteVerbose("No -AccessToken supplied, using the active Connect-MgGraph session.");
            try
            {
                httpClient = HttpHelpers.GetGraphHttpClient();
            }
            catch (Exception ex)
            {
                ThrowTerminatingError(new ErrorRecord(
                    new InvalidOperationException(
                        "No active Graph session. Run Connect-MgGraph first, or supply -AccessToken.", ex),
                    "NoGraphSession",
                    ErrorCategory.AuthenticationError,
                    null));
                return;
            }
            authProvider = new AnonymousAuthenticationProvider();
        }

        var requestAdapter = new HttpClientRequestAdapter(authProvider, httpClient: httpClient);
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Sites.Client.Models.ColumnDefinition? result;
            try
            {
                result = client.Sites[SiteId].ContentTypes[ContentTypeId].Columns.PostAsync(body, requestConfiguration =>
                {

                        if (this.IsParameterBound(nameof(Headers)))
                        {
                            foreach (System.Collections.DictionaryEntry entry in Headers!)
                                requestConfiguration.Headers.Add(entry.Key.ToString()!, entry.Value?.ToString() ?? string.Empty);
                        }
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, body));
                return;
            }

            WriteObject(result);
        }
    }
}
