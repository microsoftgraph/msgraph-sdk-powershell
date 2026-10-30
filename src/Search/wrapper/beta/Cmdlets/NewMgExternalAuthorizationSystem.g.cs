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
    [GraphRoute("POST", "/external/authorizationSystems")]
    [Cmdlet(VerbsCommon.New, "MgExternalAuthorizationSystem", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Search.Client.Models.AuthorizationSystem))]
    public class NewMgExternalAuthorizationSystemCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? AuthorizationSystemId { get; set; }

        [Parameter(Mandatory = false)]
        public string? AuthorizationSystemName { get; set; }

        [Parameter(Mandatory = false)]
        public string? AuthorizationSystemType { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Search.Client.Models.AuthorizationSystem();

    if (this.IsParameterBound(nameof(AuthorizationSystemId)))
        body.AuthorizationSystemId = AuthorizationSystemId;

    if (this.IsParameterBound(nameof(AuthorizationSystemName)))
        body.AuthorizationSystemName = AuthorizationSystemName;

    if (this.IsParameterBound(nameof(AuthorizationSystemType)))
        body.AuthorizationSystemType = AuthorizationSystemType;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Search.Client.Models.AuthorizationSystem? result;
            try
            {
                result = client.External.AuthorizationSystems.PostAsync(body, requestConfiguration =>
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
