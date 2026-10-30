#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.WindowsUpdates.Client;
using Microsoft.Graph.PowerShell.WindowsUpdates.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.WindowsUpdates
{
    [GraphRoute("POST", "/admin/windows/updates/products/{product-id}/revisions")]
    [Cmdlet(VerbsCommon.New, "MgWindowsUpdatesProductRevision", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.WindowsUpdates.Client.Models.WindowsUpdates.ProductRevision))]
    public class NewMgWindowsUpdatesProductRevisionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ProductId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsHotpatchUpdate { get; set; }

        [Parameter(Mandatory = false)]
        public string? Product { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ReleaseDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Version { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.WindowsUpdates.Client.Models.WindowsUpdates.BuildVersionDetails? OsBuild { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ProductId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.WindowsUpdates.Client.Models.WindowsUpdates.ProductRevision();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(IsHotpatchUpdate)))
        body.IsHotpatchUpdate = IsHotpatchUpdate;

    if (this.IsParameterBound(nameof(Product)))
        body.Product = Product;

    if (this.IsParameterBound(nameof(ReleaseDateTime)))
        body.ReleaseDateTime = ReleaseDateTime;

    if (this.IsParameterBound(nameof(Version)))
        body.Version = Version;

    if (this.IsParameterBound(nameof(OsBuild)))
        body.OsBuild = OsBuild;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.WindowsUpdates.Client.Models.WindowsUpdates.ProductRevision? result;
            try
            {
                result = client.Admin.Windows.Updates.Products[ProductId].Revisions.PostAsync(body, requestConfiguration =>
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
