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
    [GraphRoute("PATCH", "/external/authorizationSystems/{authorizationSystem-id}")]
    [Cmdlet(VerbsData.Update, "MgExternalAuthorizationSystem", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Search.Client.Models.AuthorizationSystem))]
    public class UpdateMgExternalAuthorizationSystemCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AuthorizationSystemId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? AuthorizationSystemId1 { get; set; }

        [Parameter(Mandatory = false)]
        public string? AuthorizationSystemName { get; set; }

        [Parameter(Mandatory = false)]
        public string? AuthorizationSystemType { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AuthorizationSystemId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Search.Client.Models.AuthorizationSystem();

    if (this.IsParameterBound(nameof(AuthorizationSystemId1)))
        body.AuthorizationSystemId = AuthorizationSystemId1;

    if (this.IsParameterBound(nameof(AuthorizationSystemName)))
        body.AuthorizationSystemName = AuthorizationSystemName;

    if (this.IsParameterBound(nameof(AuthorizationSystemType)))
        body.AuthorizationSystemType = AuthorizationSystemType;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Search.Client.Models.AuthorizationSystem? result;
            try
            {
                result = client.External.AuthorizationSystems[AuthorizationSystemId].PatchAsync(body, requestConfiguration =>
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
                    result = client.External.AuthorizationSystems[AuthorizationSystemId].GetAsync().GetAwaiter().GetResult();
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
