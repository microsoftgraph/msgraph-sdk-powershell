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
    [GraphRoute("PATCH", "/users/{user-id}/mobileAppIntentAndStates/{mobileAppIntentAndState-id}")]
    [Cmdlet(VerbsData.Update, "MgUserMobileAppIntentAndState", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.MobileAppIntentAndState))]
    public class UpdateMgUserMobileAppIntentAndStateCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string MobileAppIntentAndStateId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? ManagedDeviceIdentifier { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserId1 { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.MobileAppIntentAndStateDetail[]? MobileAppList { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(MobileAppIntentAndStateId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.MobileAppIntentAndState();

    if (this.IsParameterBound(nameof(ManagedDeviceIdentifier)))
        body.ManagedDeviceIdentifier = ManagedDeviceIdentifier;

    if (this.IsParameterBound(nameof(UserId1)))
        body.UserId = UserId1;

    if (this.IsParameterBound(nameof(MobileAppList)))
        body.MobileAppList = MobileAppList!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.MobileAppIntentAndState? result;
            try
            {
                result = client.Users[UserId].MobileAppIntentAndStates[MobileAppIntentAndStateId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, MobileAppIntentAndStateId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Users[UserId].MobileAppIntentAndStates[MobileAppIntentAndStateId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, MobileAppIntentAndStateId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
