#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.DirectoryManagement
{
    [GraphRoute("POST", "/contracts/getByIds")]
    [Cmdlet(VerbsCommon.Get, "MgContractById", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Contracts.GetByIds.GetByIdsPostResponse))]
    public class GetMgContractByIdCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string[]? Ids { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? Types { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Get"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Contracts.GetByIds.GetByIdsPostRequestBody();

    if (this.IsParameterBound(nameof(Ids)))
        body.Ids = Ids!.ToList();

    if (this.IsParameterBound(nameof(Types)))
        body.Types = Types!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Contracts.GetByIds.GetByIdsPostResponse? result;
            try
            {
                result = client.Contracts.GetByIds.PostAsGetByIdsPostResponseAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }

            WriteObject(result);
        }
    }
}
