#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client;
using Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement.Enrollment
{
    [GraphRoute("PATCH", "/deviceManagement/conditionalAccessSettings")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementConditionalAccessSetting", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.OnPremisesConditionalAccessSettings))]
    public class UpdateMgDeviceManagementConditionalAccessSettingCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public bool? Enabled { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.Guid?[]? ExcludedGroups { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.Guid?[]? IncludedGroups { get; set; }

        [Parameter(Mandatory = false)]
        public bool? OverrideDefaultRule { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.OnPremisesConditionalAccessSettings();

    if (this.IsParameterBound(nameof(Enabled)))
        body.Enabled = Enabled;

    if (this.IsParameterBound(nameof(ExcludedGroups)))
        body.ExcludedGroups = ExcludedGroups!.ToList();

    if (this.IsParameterBound(nameof(IncludedGroups)))
        body.IncludedGroups = IncludedGroups!.ToList();

    if (this.IsParameterBound(nameof(OverrideDefaultRule)))
        body.OverrideDefaultRule = OverrideDefaultRule;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.OnPremisesConditionalAccessSettings? result;
            try
            {
                result = client.DeviceManagement.ConditionalAccessSettings.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.ConditionalAccessSettings.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, null);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
