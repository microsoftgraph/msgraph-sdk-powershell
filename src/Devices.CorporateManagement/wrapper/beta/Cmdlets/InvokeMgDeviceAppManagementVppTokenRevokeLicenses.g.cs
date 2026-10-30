#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client;
using Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Devices.CorporateManagement
{
    [GraphRoute("POST", "/deviceAppManagement/vppTokens/{vppToken-id}/revokeLicenses")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDeviceAppManagementVppTokenRevokeLicenses", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgDeviceAppManagementVppTokenRevokeLicensesCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string VppTokenId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? NotifyManagedDevices { get; set; }

        [Parameter(Mandatory = false)]
        public bool? RevokeUntrackedLicenses { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(VppTokenId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.DeviceAppManagement.VppTokens.Item.RevokeLicenses.RevokeLicensesPostRequestBody();

    if (this.IsParameterBound(nameof(NotifyManagedDevices)))
        body.NotifyManagedDevices = NotifyManagedDevices;

    if (this.IsParameterBound(nameof(RevokeUntrackedLicenses)))
        body.RevokeUntrackedLicenses = RevokeUntrackedLicenses;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.DeviceAppManagement.VppTokens[VppTokenId].RevokeLicenses.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, VppTokenId);
                return;
            }

        }
    }
}
