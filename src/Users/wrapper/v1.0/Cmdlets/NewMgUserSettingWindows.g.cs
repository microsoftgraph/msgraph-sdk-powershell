#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Users.Client;
using Microsoft.Graph.PowerShell.Users.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Users
{
    [GraphRoute("POST", "/users/{user-id}/settings/windows")]
    [Cmdlet(VerbsCommon.New, "MgUserSettingWindows", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Users.Client.Models.WindowsSetting))]
    public class NewMgUserSettingWindowsCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? PayloadType { get; set; }

        [Parameter(Mandatory = false)]
        public string? WindowsDeviceId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Users.Client.Models.WindowsSettingType? SettingType { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UserId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Users.Client.Models.WindowsSetting();

    if (this.IsParameterBound(nameof(PayloadType)))
        body.PayloadType = PayloadType;

    if (this.IsParameterBound(nameof(WindowsDeviceId)))
        body.WindowsDeviceId = WindowsDeviceId;

    if (this.IsParameterBound(nameof(SettingType)))
        body.SettingType = SettingType;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Users.Client.Models.WindowsSetting? result;
            try
            {
                result = client.Users[UserId].Settings.Windows.PostAsync(body, requestConfiguration =>
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
