#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.DirectoryManagement
{
    [GraphRoute("POST", "/directory/subscriptions")]
    [Cmdlet(VerbsCommon.New, "MgDirectorySubscription", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.CompanySubscription))]
    public class NewMgDirectorySubscriptionCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? CommerceSubscriptionId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsTrial { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? NextLifecycleDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? OwnerId { get; set; }

        [Parameter(Mandatory = false)]
        public string? OwnerTenantId { get; set; }

        [Parameter(Mandatory = false)]
        public string? OwnerType { get; set; }

        [Parameter(Mandatory = false)]
        public string? SkuId { get; set; }

        [Parameter(Mandatory = false)]
        public string? SkuPartNumber { get; set; }

        [Parameter(Mandatory = false)]
        public string? Status { get; set; }

        [Parameter(Mandatory = false)]
        public int? TotalLicenses { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.ServicePlanInfo[]? ServiceStatus { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.CompanySubscription();

    if (this.IsParameterBound(nameof(CommerceSubscriptionId)))
        body.CommerceSubscriptionId = CommerceSubscriptionId;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(IsTrial)))
        body.IsTrial = IsTrial;

    if (this.IsParameterBound(nameof(NextLifecycleDateTime)))
        body.NextLifecycleDateTime = NextLifecycleDateTime;

    if (this.IsParameterBound(nameof(OwnerId)))
        body.OwnerId = OwnerId;

    if (this.IsParameterBound(nameof(OwnerTenantId)))
        body.OwnerTenantId = OwnerTenantId;

    if (this.IsParameterBound(nameof(OwnerType)))
        body.OwnerType = OwnerType;

    if (this.IsParameterBound(nameof(SkuId)))
        body.SkuId = SkuId;

    if (this.IsParameterBound(nameof(SkuPartNumber)))
        body.SkuPartNumber = SkuPartNumber;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;

    if (this.IsParameterBound(nameof(TotalLicenses)))
        body.TotalLicenses = TotalLicenses;

    if (this.IsParameterBound(nameof(ServiceStatus)))
        body.ServiceStatus = ServiceStatus!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.CompanySubscription? result;
            try
            {
                result = client.Directory.Subscriptions.PostAsync(body, requestConfiguration =>
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
