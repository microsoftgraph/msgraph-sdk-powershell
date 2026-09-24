#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DeviceManagement.Client;
using Microsoft.Graph.PowerShell.DeviceManagement.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement
{
    [GraphRoute("POST", "/deviceManagement/groupPolicyConfigurations/{groupPolicyConfiguration-id}/updateDefinitionValues")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDeviceManagementGroupPolicyConfigurationUpdateDefinitionValues", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgDeviceManagementGroupPolicyConfigurationUpdateDefinitionValuesCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupPolicyConfigurationId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string[]? DeletedIds { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.GroupPolicyDefinitionValue[]? Added { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.GroupPolicyDefinitionValue[]? Updated { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(GroupPolicyConfigurationId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.DeviceManagement.Client.DeviceManagement.GroupPolicyConfigurations.Item.UpdateDefinitionValues.UpdateDefinitionValuesPostRequestBody();

    if (this.IsParameterBound(nameof(DeletedIds)))
        body.DeletedIds = DeletedIds!.ToList();
    if (this.IsParameterBound(nameof(Added)))
        body.Added = Added!.ToList();

    if (this.IsParameterBound(nameof(Updated)))
        body.Updated = Updated!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.DeviceManagement.GroupPolicyConfigurations[GroupPolicyConfigurationId].UpdateDefinitionValues.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, GroupPolicyConfigurationId);
                return;
            }

        }
    }
}
