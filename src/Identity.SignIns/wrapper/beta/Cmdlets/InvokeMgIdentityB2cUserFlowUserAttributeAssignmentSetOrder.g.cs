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
    [GraphRoute("POST", "/identity/b2cUserFlows/{b2cIdentityUserFlow-id}/userAttributeAssignments/setOrder")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgIdentityB2cUserFlowUserAttributeAssignmentSetOrder", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgIdentityB2cUserFlowUserAttributeAssignmentSetOrderCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string B2cIdentityUserFlowId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.AssignmentOrder? NewAssignmentOrder { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(B2cIdentityUserFlowId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Identity.SignIns.Client.Identity.B2cUserFlows.Item.UserAttributeAssignments.SetOrder.SetOrderPostRequestBody();

    if (this.IsParameterBound(nameof(NewAssignmentOrder)))
        body.NewAssignmentOrder = NewAssignmentOrder;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Identity.B2cUserFlows[B2cIdentityUserFlowId].UserAttributeAssignments.SetOrder.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, B2cIdentityUserFlowId);
                return;
            }

        }
    }
}
