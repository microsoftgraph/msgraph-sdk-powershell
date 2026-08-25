#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Sites.Client;
using Microsoft.Graph.PowerShell.Sites.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Sites
{
    [GraphRoute("PATCH", "/groups/{group-id}/sites/{site-id}/columns/{columnDefinition-id}")]
    [Cmdlet(VerbsData.Update, "MgGroupSiteColumn", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Sites.Client.Models.ColumnDefinition))]
    public class UpdateMgGroupSiteColumnCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SiteId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string ColumnDefinitionId { get; set; } = string.Empty;

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






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ColumnDefinitionId, "Update"))
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


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Sites.Client.Models.ColumnDefinition? result;
            try
            {
                result = client.Groups[GroupId].Sites[SiteId].Columns[ColumnDefinitionId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, ColumnDefinitionId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Groups[GroupId].Sites[SiteId].Columns[ColumnDefinitionId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, ColumnDefinitionId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
