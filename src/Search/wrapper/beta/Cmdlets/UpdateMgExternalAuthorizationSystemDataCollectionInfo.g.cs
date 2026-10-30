#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Search.Client;
using Microsoft.Graph.PowerShell.Search.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Search
{
    [GraphRoute("PATCH", "/external/authorizationSystems/{authorizationSystem-id}/dataCollectionInfo")]
    [Cmdlet(VerbsData.Update, "MgExternalAuthorizationSystemDataCollectionInfo", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Search.Client.Models.DataCollectionInfo))]
    public class UpdateMgExternalAuthorizationSystemDataCollectionInfoCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AuthorizationSystemId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Search.Client.Models.EntitlementsDataCollectionInfo? Entitlements { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AuthorizationSystemId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Search.Client.Models.DataCollectionInfo();


    if (this.IsParameterBound(nameof(Entitlements)))
        body.Entitlements = Entitlements;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Search.Client.Models.DataCollectionInfo? result;
            try
            {
                result = client.External.AuthorizationSystems[AuthorizationSystemId].DataCollectionInfo.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, AuthorizationSystemId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.External.AuthorizationSystems[AuthorizationSystemId].DataCollectionInfo.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, AuthorizationSystemId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
