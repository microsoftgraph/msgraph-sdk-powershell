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
    [GraphRoute("POST", "/deviceManagement/assignmentFilters/validateFilter")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDeviceManagementAssignmentFilterValidateFilter", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.AssignmentFilterValidationResult))]
    public class InvokeMgDeviceManagementAssignmentFilterValidateFilterCommand : GraphClientCmdlet
    {



        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceAndAppManagementAssignmentFilter? DeviceAndAppManagementAssignmentFilter { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.DeviceManagement.Client.DeviceManagement.AssignmentFilters.ValidateFilter.ValidateFilterPostRequestBody();

    if (this.IsParameterBound(nameof(DeviceAndAppManagementAssignmentFilter)))
        body.DeviceAndAppManagementAssignmentFilter = DeviceAndAppManagementAssignmentFilter;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.AssignmentFilterValidationResult? result;
            try
            {
                result = client.DeviceManagement.AssignmentFilters.ValidateFilter.PostAsync(body, requestConfiguration =>
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
