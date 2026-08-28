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
    [GraphRoute("PATCH", "/deviceAppManagement/managedEBooks/{managedEBook-id}/installSummary")]
    [Cmdlet(VerbsData.Update, "MgDeviceAppManagementManagedEBookInstallSummary", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.EBookInstallSummary))]
    public class UpdateMgDeviceAppManagementManagedEBookInstallSummaryCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ManagedEBookId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public int? FailedDeviceCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? FailedUserCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? InstalledDeviceCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? InstalledUserCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? NotInstalledDeviceCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? NotInstalledUserCount { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ManagedEBookId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.EBookInstallSummary();

    if (this.IsParameterBound(nameof(FailedDeviceCount)))
        body.FailedDeviceCount = FailedDeviceCount;

    if (this.IsParameterBound(nameof(FailedUserCount)))
        body.FailedUserCount = FailedUserCount;

    if (this.IsParameterBound(nameof(InstalledDeviceCount)))
        body.InstalledDeviceCount = InstalledDeviceCount;

    if (this.IsParameterBound(nameof(InstalledUserCount)))
        body.InstalledUserCount = InstalledUserCount;

    if (this.IsParameterBound(nameof(NotInstalledDeviceCount)))
        body.NotInstalledDeviceCount = NotInstalledDeviceCount;

    if (this.IsParameterBound(nameof(NotInstalledUserCount)))
        body.NotInstalledUserCount = NotInstalledUserCount;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.EBookInstallSummary? result;
            try
            {
                result = client.DeviceAppManagement.ManagedEBooks[ManagedEBookId].InstallSummary.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, ManagedEBookId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceAppManagement.ManagedEBooks[ManagedEBookId].InstallSummary.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, ManagedEBookId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
