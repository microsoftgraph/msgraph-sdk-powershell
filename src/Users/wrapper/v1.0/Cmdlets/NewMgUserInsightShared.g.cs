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
    [GraphRoute("POST", "/users/{user-id}/insights/shared")]
    [Cmdlet(VerbsCommon.New, "MgUserInsightShared", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Users.Client.Models.SharedInsight))]
    public class NewMgUserInsightSharedCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Users.Client.Models.SharingDetail? LastShared { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Users.Client.Models.SharingDetail[]? SharingHistory { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UserId, "New"))
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
                result = client.Users[UserId].Insights.Shared.PostAsync(body, requestConfiguration =>
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
