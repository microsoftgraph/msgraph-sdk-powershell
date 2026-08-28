#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client;
using Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Devices.CorporateManagement
{
    [GraphRoute("PATCH", "/deviceAppManagement/vppTokens/{vppToken-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceAppManagementVppToken", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.VppToken))]
    public class UpdateMgDeviceAppManagementVppTokenCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string VppTokenId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? AppleId { get; set; }

        [Parameter(Mandatory = false)]
        public bool? AutomaticallyUpdateApps { get; set; }

        [Parameter(Mandatory = false)]
        public string? CountryOrRegion { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ExpirationDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastSyncDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? OrganizationName { get; set; }

        [Parameter(Mandatory = false)]
        public string? Token { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.VppTokenSyncStatus? LastSyncStatus { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.VppTokenState? State { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.VppTokenAccountType? VppTokenAccountType { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(VppTokenId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.VppToken();

    if (this.IsParameterBound(nameof(AppleId)))
        body.AppleId = AppleId;

    if (this.IsParameterBound(nameof(AutomaticallyUpdateApps)))
        body.AutomaticallyUpdateApps = AutomaticallyUpdateApps;

    if (this.IsParameterBound(nameof(CountryOrRegion)))
        body.CountryOrRegion = CountryOrRegion;

    if (this.IsParameterBound(nameof(ExpirationDateTime)))
        body.ExpirationDateTime = ExpirationDateTime;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(LastSyncDateTime)))
        body.LastSyncDateTime = LastSyncDateTime;

    if (this.IsParameterBound(nameof(OrganizationName)))
        body.OrganizationName = OrganizationName;

    if (this.IsParameterBound(nameof(Token)))
        body.Token = Token;

    if (this.IsParameterBound(nameof(LastSyncStatus)))
        body.LastSyncStatus = LastSyncStatus;

    if (this.IsParameterBound(nameof(State)))
        body.State = State;

    if (this.IsParameterBound(nameof(VppTokenAccountType)))
        body.VppTokenAccountType = VppTokenAccountType;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.VppToken? result;
            try
            {
                result = client.DeviceAppManagement.VppTokens[VppTokenId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, VppTokenId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceAppManagement.VppTokens[VppTokenId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, VppTokenId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
