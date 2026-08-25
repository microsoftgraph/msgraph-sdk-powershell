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
    [GraphRoute("PATCH", "/users/{user-id}/settings/windows/{windowsSetting-id}/instances/{windowsSettingInstance-id}")]
    [Cmdlet(VerbsData.Update, "MgUserSettingWindowsInstance", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Users.Client.Models.WindowsSettingInstance))]
    public class UpdateMgUserSettingWindowsInstanceCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string WindowsSettingId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string WindowsSettingInstanceId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ExpirationDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Payload { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(WindowsSettingInstanceId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Users.Client.Models.WindowsSettingInstance();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(ExpirationDateTime)))
        body.ExpirationDateTime = ExpirationDateTime;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(Payload)))
        body.Payload = Payload;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Users.Client.Models.WindowsSettingInstance? result;
            try
            {
                result = client.Users[UserId].Settings.Windows[WindowsSettingId].Instances[WindowsSettingInstanceId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, WindowsSettingInstanceId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Users[UserId].Settings.Windows[WindowsSettingId].Instances[WindowsSettingInstanceId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, WindowsSettingInstanceId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
