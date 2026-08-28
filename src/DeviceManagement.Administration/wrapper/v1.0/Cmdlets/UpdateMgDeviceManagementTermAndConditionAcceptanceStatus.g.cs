#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client;
using Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement.Administration
{
    [GraphRoute("PATCH", "/deviceManagement/termsAndConditions/{termsAndConditions-id}/acceptanceStatuses/{termsAndConditionsAcceptanceStatus-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementTermAndConditionAcceptanceStatus", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.TermsAndConditionsAcceptanceStatus))]
    public class UpdateMgDeviceManagementTermAndConditionAcceptanceStatusCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string TermsAndConditionsId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string TermsAndConditionsAcceptanceStatusId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? AcceptedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public int? AcceptedVersion { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserDisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserPrincipalName { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(TermsAndConditionsAcceptanceStatusId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.TermsAndConditionsAcceptanceStatus();

    if (this.IsParameterBound(nameof(AcceptedDateTime)))
        body.AcceptedDateTime = AcceptedDateTime;

    if (this.IsParameterBound(nameof(AcceptedVersion)))
        body.AcceptedVersion = AcceptedVersion;

    if (this.IsParameterBound(nameof(UserDisplayName)))
        body.UserDisplayName = UserDisplayName;

    if (this.IsParameterBound(nameof(UserPrincipalName)))
        body.UserPrincipalName = UserPrincipalName;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.TermsAndConditionsAcceptanceStatus? result;
            try
            {
                result = client.DeviceManagement.TermsAndConditions[TermsAndConditionsId].AcceptanceStatuses[TermsAndConditionsAcceptanceStatusId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, TermsAndConditionsAcceptanceStatusId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.TermsAndConditions[TermsAndConditionsId].AcceptanceStatuses[TermsAndConditionsAcceptanceStatusId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, TermsAndConditionsAcceptanceStatusId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
