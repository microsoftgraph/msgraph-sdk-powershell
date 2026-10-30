#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.Governance.Client;
using Microsoft.Graph.PowerShell.Identity.Governance.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.Governance
{
    [GraphRoute("PATCH", "/privilegedOperationEvents/{privilegedOperationEvent-id}")]
    [Cmdlet(VerbsData.Update, "MgPrivilegedOperationEvent", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.PrivilegedOperationEvent))]
    public class UpdateMgPrivilegedOperationEventCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string PrivilegedOperationEventId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? AdditionalInformation { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreationDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ExpirationDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? ReferenceKey { get; set; }

        [Parameter(Mandatory = false)]
        public string? ReferenceSystem { get; set; }

        [Parameter(Mandatory = false)]
        public string? RequestorId { get; set; }

        [Parameter(Mandatory = false)]
        public string? RequestorName { get; set; }

        [Parameter(Mandatory = false)]
        public string? RequestType { get; set; }

        [Parameter(Mandatory = false)]
        public string? RoleId { get; set; }

        [Parameter(Mandatory = false)]
        public string? RoleName { get; set; }

        [Parameter(Mandatory = false)]
        public string? TenantId { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserId { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserMail { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserName { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PrivilegedOperationEventId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.PrivilegedOperationEvent();

    if (this.IsParameterBound(nameof(AdditionalInformation)))
        body.AdditionalInformation = AdditionalInformation;

    if (this.IsParameterBound(nameof(CreationDateTime)))
        body.CreationDateTime = CreationDateTime;

    if (this.IsParameterBound(nameof(ExpirationDateTime)))
        body.ExpirationDateTime = ExpirationDateTime;

    if (this.IsParameterBound(nameof(ReferenceKey)))
        body.ReferenceKey = ReferenceKey;

    if (this.IsParameterBound(nameof(ReferenceSystem)))
        body.ReferenceSystem = ReferenceSystem;

    if (this.IsParameterBound(nameof(RequestorId)))
        body.RequestorId = RequestorId;

    if (this.IsParameterBound(nameof(RequestorName)))
        body.RequestorName = RequestorName;

    if (this.IsParameterBound(nameof(RequestType)))
        body.RequestType = RequestType;

    if (this.IsParameterBound(nameof(RoleId)))
        body.RoleId = RoleId;

    if (this.IsParameterBound(nameof(RoleName)))
        body.RoleName = RoleName;

    if (this.IsParameterBound(nameof(TenantId)))
        body.TenantId = TenantId;

    if (this.IsParameterBound(nameof(UserId)))
        body.UserId = UserId;

    if (this.IsParameterBound(nameof(UserMail)))
        body.UserMail = UserMail;

    if (this.IsParameterBound(nameof(UserName)))
        body.UserName = UserName;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.PrivilegedOperationEvent? result;
            try
            {
                result = client.PrivilegedOperationEvents[PrivilegedOperationEventId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, PrivilegedOperationEventId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.PrivilegedOperationEvents[PrivilegedOperationEventId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, PrivilegedOperationEventId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
