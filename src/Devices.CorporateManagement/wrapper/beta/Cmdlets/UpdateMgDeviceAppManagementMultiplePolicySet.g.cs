#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client;
using Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Devices.CorporateManagement
{
    [GraphRoute("POST", "/deviceAppManagement/policySets/{policySet-id}/update")]
    [Cmdlet(VerbsData.Update, "MgDeviceAppManagementMultiplePolicySet", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class UpdateMgDeviceAppManagementMultiplePolicySetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string PolicySetId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string[]? DeletedPolicySetItems { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.PolicySetItem[]? AddedPolicySetItems { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.PolicySetItem[]? UpdatedPolicySetItems { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.PolicySetAssignment[]? Assignments { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PolicySetId, "Update"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.DeviceAppManagement.PolicySets.Item.Update.UpdatePostRequestBody();

    if (this.IsParameterBound(nameof(DeletedPolicySetItems)))
        body.DeletedPolicySetItems = DeletedPolicySetItems!.ToList();
    if (this.IsParameterBound(nameof(AddedPolicySetItems)))
        body.AddedPolicySetItems = AddedPolicySetItems!.ToList();

    if (this.IsParameterBound(nameof(UpdatedPolicySetItems)))
        body.UpdatedPolicySetItems = UpdatedPolicySetItems!.ToList();

    if (this.IsParameterBound(nameof(Assignments)))
        body.Assignments = Assignments!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.DeviceAppManagement.PolicySets[PolicySetId].Update.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, PolicySetId);
                return;
            }

        }
    }
}
