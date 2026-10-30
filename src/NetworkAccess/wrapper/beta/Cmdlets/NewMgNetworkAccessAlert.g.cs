#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.NetworkAccess.Client;
using Microsoft.Graph.PowerShell.NetworkAccess.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.NetworkAccess
{
    [GraphRoute("POST", "/networkAccess/alerts")]
    [Cmdlet(VerbsCommon.New, "MgNetworkAccessAlert", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.Alert))]
    public class NewMgNetworkAccessAlertCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? ComponentName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreationDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DetectionTechnology { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? FirstActivityDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsPreview { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastActivityDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? ProductName { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? SubTechniques { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? Techniques { get; set; }

        [Parameter(Mandatory = false)]
        public string? VendorName { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.AlertAction[]? Actions { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.AlertType? AlertType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.IntentCategory?[]? Categories { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.ExtendedProperties? ExtendedProperties { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.RelatedResource[]? RelatedResources { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.AlertSeverity? Severity { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.Alert();

    if (this.IsParameterBound(nameof(ComponentName)))
        body.ComponentName = ComponentName;

    if (this.IsParameterBound(nameof(CreationDateTime)))
        body.CreationDateTime = CreationDateTime;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DetectionTechnology)))
        body.DetectionTechnology = DetectionTechnology;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(FirstActivityDateTime)))
        body.FirstActivityDateTime = FirstActivityDateTime;

    if (this.IsParameterBound(nameof(IsPreview)))
        body.IsPreview = IsPreview;

    if (this.IsParameterBound(nameof(LastActivityDateTime)))
        body.LastActivityDateTime = LastActivityDateTime;

    if (this.IsParameterBound(nameof(ProductName)))
        body.ProductName = ProductName;

    if (this.IsParameterBound(nameof(SubTechniques)))
        body.SubTechniques = SubTechniques!.ToList();

    if (this.IsParameterBound(nameof(Techniques)))
        body.Techniques = Techniques!.ToList();

    if (this.IsParameterBound(nameof(VendorName)))
        body.VendorName = VendorName;

    if (this.IsParameterBound(nameof(Actions)))
        body.Actions = Actions!.ToList();

    if (this.IsParameterBound(nameof(AlertType)))
        body.AlertType = AlertType;

    if (this.IsParameterBound(nameof(Categories)))
        body.Categories = Categories!.ToList();

    if (this.IsParameterBound(nameof(ExtendedProperties)))
        body.ExtendedProperties = ExtendedProperties;

    if (this.IsParameterBound(nameof(RelatedResources)))
        body.RelatedResources = RelatedResources!.ToList();

    if (this.IsParameterBound(nameof(Severity)))
        body.Severity = Severity;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.Alert? result;
            try
            {
                result = client.NetworkAccess.Alerts.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
