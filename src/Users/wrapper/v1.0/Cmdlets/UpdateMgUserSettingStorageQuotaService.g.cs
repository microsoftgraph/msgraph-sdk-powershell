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
    [GraphRoute("PATCH", "/users/{user-id}/settings/storage/quota/services/{serviceStorageQuotaBreakdown-id}")]
    [Cmdlet(VerbsData.Update, "MgUserSettingStorageQuotaService", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Users.Client.Models.ServiceStorageQuotaBreakdown))]
    public class UpdateMgUserSettingStorageQuotaServiceCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ServiceStorageQuotaBreakdownId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? ManageWebUrl { get; set; }

        [Parameter(Mandatory = false)]
        public long? Used { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ServiceStorageQuotaBreakdownId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Users.Client.Models.ServiceStorageQuotaBreakdown();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(ManageWebUrl)))
        body.ManageWebUrl = ManageWebUrl;

    if (this.IsParameterBound(nameof(Used)))
        body.Used = Used;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Users.Client.Models.ServiceStorageQuotaBreakdown? result;
            try
            {
                result = client.Users[UserId].Settings.Storage.Quota.Services[ServiceStorageQuotaBreakdownId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, ServiceStorageQuotaBreakdownId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Users[UserId].Settings.Storage.Quota.Services[ServiceStorageQuotaBreakdownId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, ServiceStorageQuotaBreakdownId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
