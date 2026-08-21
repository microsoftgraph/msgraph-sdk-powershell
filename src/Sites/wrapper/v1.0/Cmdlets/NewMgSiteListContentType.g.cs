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
    [GraphRoute("POST", "/sites/{site-id}/lists/{list-id}/contentTypes")]
    [Cmdlet(VerbsCommon.New, "MgSiteListContentType", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Sites.Client.Models.ContentType))]
    public class NewMgSiteListContentTypeCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SiteId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ListId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string[]? AssociatedHubsUrls { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? Group { get; set; }

        [Parameter(Mandatory = false)]
        public bool? Hidden { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsBuiltIn { get; set; }

        [Parameter(Mandatory = false)]
        public string? Name { get; set; }

        [Parameter(Mandatory = false)]
        public string? ParentId { get; set; }

        [Parameter(Mandatory = false)]
        public bool? PropagateChanges { get; set; }

        [Parameter(Mandatory = false)]
        public bool? ReadOnly { get; set; }

        [Parameter(Mandatory = false)]
        public bool? Sealed { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.DocumentSet? DocumentSet { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.DocumentSetContent? DocumentTemplate { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.ItemReference? InheritedFrom { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.ContentTypeOrder? Order { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ListId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Sites.Client.Models.ContentType();

    if (this.IsParameterBound(nameof(AssociatedHubsUrls)))
        body.AssociatedHubsUrls = AssociatedHubsUrls!.ToList();

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(Group)))
        body.Group = Group;

    if (this.IsParameterBound(nameof(Hidden)))
        body.Hidden = Hidden;

    if (this.IsParameterBound(nameof(IsBuiltIn)))
        body.IsBuiltIn = IsBuiltIn;

    if (this.IsParameterBound(nameof(Name)))
        body.Name = Name;

    if (this.IsParameterBound(nameof(ParentId)))
        body.ParentId = ParentId;

    if (this.IsParameterBound(nameof(PropagateChanges)))
        body.PropagateChanges = PropagateChanges;

    if (this.IsParameterBound(nameof(ReadOnly)))
        body.ReadOnly = ReadOnly;

    if (this.IsParameterBound(nameof(Sealed)))
        body.Sealed = Sealed;

    if (this.IsParameterBound(nameof(DocumentSet)))
        body.DocumentSet = DocumentSet;

    if (this.IsParameterBound(nameof(DocumentTemplate)))
        body.DocumentTemplate = DocumentTemplate;

    if (this.IsParameterBound(nameof(InheritedFrom)))
        body.InheritedFrom = InheritedFrom;

    if (this.IsParameterBound(nameof(Order)))
        body.Order = Order;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Sites.Client.Models.ContentType? result;
            try
            {
                result = client.Sites[SiteId].Lists[ListId].ContentTypes.PostAsync(body, requestConfiguration =>
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
