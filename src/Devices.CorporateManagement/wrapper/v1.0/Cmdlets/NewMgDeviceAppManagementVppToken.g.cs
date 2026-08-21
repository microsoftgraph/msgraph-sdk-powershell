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
    [GraphRoute("POST", "/deviceAppManagement/vppTokens")]
    [Cmdlet(VerbsCommon.New, "MgDeviceAppManagementVppToken", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.VppToken))]
    public class NewMgDeviceAppManagementVppTokenCommand : GraphClientCmdlet
    {


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
            if (!ShouldProcess(null, "New"))
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
                result = client.DeviceAppManagement.VppTokens.PostAsync(body, requestConfiguration =>
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
