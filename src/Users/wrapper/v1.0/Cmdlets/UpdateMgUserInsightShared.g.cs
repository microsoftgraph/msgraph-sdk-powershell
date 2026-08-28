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
    [GraphRoute("PATCH", "/users/{user-id}/insights/shared/{sharedInsight-id}")]
    [Cmdlet(VerbsData.Update, "MgUserInsightShared", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Users.Client.Models.SharedInsight))]
    public class UpdateMgUserInsightSharedCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SharedInsightId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Users.Client.Models.SharingDetail? LastShared { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Users.Client.Models.SharingDetail[]? SharingHistory { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SharedInsightId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Users.Client.Models.SharedInsight();


    if (this.IsParameterBound(nameof(LastShared)))
        body.LastShared = LastShared;

    if (this.IsParameterBound(nameof(SharingHistory)))
        body.SharingHistory = SharingHistory!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Users.Client.Models.SharedInsight? result;
            try
            {
                result = client.Users[UserId].Insights.Shared[SharedInsightId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, SharedInsightId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Users[UserId].Insights.Shared[SharedInsightId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, SharedInsightId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
