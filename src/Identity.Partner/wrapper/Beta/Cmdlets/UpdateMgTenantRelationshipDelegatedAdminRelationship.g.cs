#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.Partner.Client;
using Microsoft.Graph.PowerShell.Identity.Partner.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.Partner
{
    [GraphRoute("PATCH", "/tenantRelationships/delegatedAdminRelationships/{delegatedAdminRelationship-id}")]
    [Cmdlet(VerbsData.Update, "MgTenantRelationshipDelegatedAdminRelationship", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Partner.Client.Models.DelegatedAdminRelationship))]
    public class UpdateMgTenantRelationshipDelegatedAdminRelationshipCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DelegatedAdminRelationshipId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ActivatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.TimeSpan? AutoExtendDuration { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.TimeSpan? Duration { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? EndDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Partner.Client.Models.DelegatedAdminAccessDetails? AccessDetails { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Partner.Client.Models.DelegatedAdminRelationshipCustomerParticipant? Customer { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Partner.Client.Models.DelegatedAdminRelationshipStatus? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DelegatedAdminRelationshipId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Partner.Client.Models.DelegatedAdminRelationship();

    if (this.IsParameterBound(nameof(ActivatedDateTime)))
        body.ActivatedDateTime = ActivatedDateTime;

    if (this.IsParameterBound(nameof(AutoExtendDuration)))
        body.AutoExtendDuration = AutoExtendDuration;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(Duration)))
        body.Duration = Duration;

    if (this.IsParameterBound(nameof(EndDateTime)))
        body.EndDateTime = EndDateTime;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(AccessDetails)))
        body.AccessDetails = AccessDetails;

    if (this.IsParameterBound(nameof(Customer)))
        body.Customer = Customer;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Partner.Client.Models.DelegatedAdminRelationship? result;
            try
            {
                result = client.TenantRelationships.DelegatedAdminRelationships[DelegatedAdminRelationshipId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DelegatedAdminRelationshipId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.TenantRelationships.DelegatedAdminRelationships[DelegatedAdminRelationshipId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, DelegatedAdminRelationshipId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
