#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Applications.Client;
using Microsoft.Graph.PowerShell.Applications.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Applications
{
    [GraphRoute("POST", "/servicePrincipals/{servicePrincipal-id}/tokenLifetimePolicies/$ref")]
    [Cmdlet(VerbsCommon.New, "MgServicePrincipalTokenLifetimePolicyByRef", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class NewMgServicePrincipalTokenLifetimePolicyByRefCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ServicePrincipalId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? OdataId { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ServicePrincipalId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Applications.Client.Models.ReferenceCreate();

    if (this.IsParameterBound(nameof(OdataId)))
        body.OdataId = OdataId;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.ServicePrincipals[ServicePrincipalId].TokenLifetimePolicies.Ref.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ServicePrincipalId);
                return;
            }

        }
    }
}
