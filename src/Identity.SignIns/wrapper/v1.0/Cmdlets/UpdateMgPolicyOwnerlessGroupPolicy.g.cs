#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.SignIns
{
    [GraphRoute("PATCH", "/policies/ownerlessGroupPolicy")]
    [Cmdlet(VerbsData.Update, "MgPolicyOwnerlessGroupPolicy", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.OwnerlessGroupPolicy))]
    public class UpdateMgPolicyOwnerlessGroupPolicyCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string[]? EnabledGroupIds { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public long? MaxMembersToNotify { get; set; }

        [Parameter(Mandatory = false)]
        public long? NotificationDurationInWeeks { get; set; }

        [Parameter(Mandatory = false)]
        public string? PolicyWebUrl { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.EmailDetails? EmailInfo { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.TargetOwners? TargetOwners { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.OwnerlessGroupPolicy();

    if (this.IsParameterBound(nameof(EnabledGroupIds)))
        body.EnabledGroupIds = EnabledGroupIds!.ToList();

    if (this.IsParameterBound(nameof(IsEnabled)))
        body.IsEnabled = IsEnabled;

    if (this.IsParameterBound(nameof(MaxMembersToNotify)))
        body.MaxMembersToNotify = MaxMembersToNotify;

    if (this.IsParameterBound(nameof(NotificationDurationInWeeks)))
        body.NotificationDurationInWeeks = NotificationDurationInWeeks;

    if (this.IsParameterBound(nameof(PolicyWebUrl)))
        body.PolicyWebUrl = PolicyWebUrl;

    if (this.IsParameterBound(nameof(EmailInfo)))
        body.EmailInfo = EmailInfo;

    if (this.IsParameterBound(nameof(TargetOwners)))
        body.TargetOwners = TargetOwners;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.OwnerlessGroupPolicy? result;
            try
            {
                result = client.Policies.OwnerlessGroupPolicy.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Policies.OwnerlessGroupPolicy.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, null);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
