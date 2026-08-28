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
    [GraphRoute("POST", "/deviceAppManagement/managedEBooks/{managedEBook-id}/userStateSummary")]
    [Cmdlet(VerbsCommon.New, "MgDeviceAppManagementManagedEBookUserStateSummary", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.UserInstallStateSummary))]
    public class NewMgDeviceAppManagementManagedEBookUserStateSummaryCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ManagedEBookId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public int? FailedDeviceCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? InstalledDeviceCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? NotInstalledDeviceCount { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserName { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ManagedEBookId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.UserInstallStateSummary();

    if (this.IsParameterBound(nameof(FailedDeviceCount)))
        body.FailedDeviceCount = FailedDeviceCount;

    if (this.IsParameterBound(nameof(InstalledDeviceCount)))
        body.InstalledDeviceCount = InstalledDeviceCount;

    if (this.IsParameterBound(nameof(NotInstalledDeviceCount)))
        body.NotInstalledDeviceCount = NotInstalledDeviceCount;

    if (this.IsParameterBound(nameof(UserName)))
        body.UserName = UserName;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.UserInstallStateSummary? result;
            try
            {
                result = client.DeviceAppManagement.ManagedEBooks[ManagedEBookId].UserStateSummary.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
