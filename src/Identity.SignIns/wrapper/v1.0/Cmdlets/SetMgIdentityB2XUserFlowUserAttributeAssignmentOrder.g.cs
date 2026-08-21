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
    [GraphRoute("POST", "/identity/b2xUserFlows/{b2xIdentityUserFlow-id}/userAttributeAssignments/setOrder")]
    [Cmdlet(VerbsCommon.Set, "MgIdentityB2XUserFlowUserAttributeAssignmentOrder", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class SetMgIdentityB2XUserFlowUserAttributeAssignmentOrderCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string B2xIdentityUserFlowId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.AssignmentOrder? NewAssignmentOrder { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(B2xIdentityUserFlowId, "Set"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Identity.SignIns.Client.Identity.B2xUserFlows.Item.UserAttributeAssignments.SetOrder.SetOrderPostRequestBody();

    if (this.IsParameterBound(nameof(NewAssignmentOrder)))
        body.NewAssignmentOrder = NewAssignmentOrder;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Identity.B2xUserFlows[B2xIdentityUserFlowId].UserAttributeAssignments.SetOrder.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, B2xIdentityUserFlowId);
                return;
            }

        }
    }
}
