#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Security.Client;
using Microsoft.Graph.PowerShell.Security.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Security
{
    [GraphRoute("POST", "/security/cases/ediscoveryCases/{ediscoveryCase-id}/custodians/{ediscoveryCustodian-id}/microsoft.graph.security.removeHold")]
    [Cmdlet(VerbsCommon.Remove, "MgSecurityCaseEdiscoveryCaseCustodianHold", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class RemoveMgSecurityCaseEdiscoveryCaseCustodianHoldCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string EdiscoveryCaseId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string EdiscoveryCustodianId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(EdiscoveryCustodianId, "Remove"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Security.Cases.EdiscoveryCases[EdiscoveryCaseId].Custodians[EdiscoveryCustodianId].MicrosoftGraphSecurityRemoveHold.PostAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, EdiscoveryCustodianId);
                return;
            }

        }
    }
}
