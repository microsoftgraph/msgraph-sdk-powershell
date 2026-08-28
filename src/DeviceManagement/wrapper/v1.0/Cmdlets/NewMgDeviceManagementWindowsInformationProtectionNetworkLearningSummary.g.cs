#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DeviceManagement.Client;
using Microsoft.Graph.PowerShell.DeviceManagement.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement
{
    [GraphRoute("POST", "/deviceManagement/windowsInformationProtectionNetworkLearningSummaries")]
    [Cmdlet(VerbsCommon.New, "MgDeviceManagementWindowsInformationProtectionNetworkLearningSummary", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.WindowsInformationProtectionNetworkLearningSummary))]
    public class NewMgDeviceManagementWindowsInformationProtectionNetworkLearningSummaryCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public int? DeviceCount { get; set; }

        [Parameter(Mandatory = false)]
        public string? Url { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.WindowsInformationProtectionNetworkLearningSummary();

    if (this.IsParameterBound(nameof(DeviceCount)))
        body.DeviceCount = DeviceCount;

    if (this.IsParameterBound(nameof(Url)))
        body.Url = Url;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.WindowsInformationProtectionNetworkLearningSummary? result;
            try
            {
                result = client.DeviceManagement.WindowsInformationProtectionNetworkLearningSummaries.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
