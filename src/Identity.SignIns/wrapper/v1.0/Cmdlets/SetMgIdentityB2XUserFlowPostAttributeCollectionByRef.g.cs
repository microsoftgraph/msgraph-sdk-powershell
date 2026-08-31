#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.SignIns
{
    [GraphRoute("PUT", "/identity/b2xUserFlows/{b2xIdentityUserFlow-id}/apiConnectorConfiguration/postAttributeCollection/$ref")]
    [Cmdlet(VerbsCommon.Set, "MgIdentityB2XUserFlowPostAttributeCollectionByRef", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class SetMgIdentityB2XUserFlowPostAttributeCollectionByRefCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string B2xIdentityUserFlowId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? OdataId { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(B2xIdentityUserFlowId, "Set"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.ReferenceUpdate();

    if (this.IsParameterBound(nameof(OdataId)))
        body.OdataId = OdataId;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Identity.B2xUserFlows[B2xIdentityUserFlowId].ApiConnectorConfiguration.PostAttributeCollection.Ref.PutAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, B2xIdentityUserFlowId);
                return;
            }

        }
    }
}
