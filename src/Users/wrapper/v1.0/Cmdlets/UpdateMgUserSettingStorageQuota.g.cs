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
    [GraphRoute("PATCH", "/users/{user-id}/settings/storage/quota")]
    [Cmdlet(VerbsData.Update, "MgUserSettingStorageQuota", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Users.Client.Models.UnifiedStorageQuota))]
    public class UpdateMgUserSettingStorageQuotaCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public long? Deleted { get; set; }

        [Parameter(Mandatory = false)]
        public string? ManageWebUrl { get; set; }

        [Parameter(Mandatory = false)]
        public long? Remaining { get; set; }

        [Parameter(Mandatory = false)]
        public string? State { get; set; }

        [Parameter(Mandatory = false)]
        public long? Total { get; set; }

        [Parameter(Mandatory = false)]
        public long? Used { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UserId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Users.Client.Models.UnifiedStorageQuota();

    if (this.IsParameterBound(nameof(Deleted)))
        body.Deleted = Deleted;

    if (this.IsParameterBound(nameof(ManageWebUrl)))
        body.ManageWebUrl = ManageWebUrl;

    if (this.IsParameterBound(nameof(Remaining)))
        body.Remaining = Remaining;

    if (this.IsParameterBound(nameof(State)))
        body.State = State;

    if (this.IsParameterBound(nameof(Total)))
        body.Total = Total;

    if (this.IsParameterBound(nameof(Used)))
        body.Used = Used;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Users.Client.Models.UnifiedStorageQuota? result;
            try
            {
                result = client.Users[UserId].Settings.Storage.Quota.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, UserId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Users[UserId].Settings.Storage.Quota.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, UserId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
