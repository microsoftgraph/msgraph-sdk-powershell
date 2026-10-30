#nullable enable

using System;
using System.Collections.Generic;
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
    [GraphRoute("GET", "/identity/b2cUserFlows/{b2cIdentityUserFlow-id}/userAttributeAssignments/getOrder()")]
    [Cmdlet(VerbsCommon.Get, "MgIdentityB2cUserFlowUserAttributeAssignmentGetOrder")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.AssignmentOrder))]
    public class GetMgIdentityB2cUserFlowUserAttributeAssignmentGetOrderCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string B2cIdentityUserFlowId { get; set; } = string.Empty;









        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.AssignmentOrder? result;
            try
            {
                result = client.Identity.B2cUserFlows[B2cIdentityUserFlowId].UserAttributeAssignments.GetOrder.GetAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, B2cIdentityUserFlowId);
                return;
            }

            WriteObject(result);
        }
    }
}
