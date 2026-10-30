#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client;
using Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Devices.CorporateManagement
{
    [GraphRoute("PATCH", "/deviceAppManagement/wdacSupplementalPolicies/{windowsDefenderApplicationControlSupplementalPolicy-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceAppManagementWdacSupplementalPolicy", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.WindowsDefenderApplicationControlSupplementalPolicy))]
    public class UpdateMgDeviceAppManagementWdacSupplementalPolicyCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string WindowsDefenderApplicationControlSupplementalPolicyId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public byte[]? Content { get; set; }

        [Parameter(Mandatory = false)]
        public string? ContentFileName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreationDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? RoleScopeTagIds { get; set; }

        [Parameter(Mandatory = false)]
        public string? Version { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(WindowsDefenderApplicationControlSupplementalPolicyId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.WindowsDefenderApplicationControlSupplementalPolicy();

    if (this.IsParameterBound(nameof(Content)))
        body.Content = Content;

    if (this.IsParameterBound(nameof(ContentFileName)))
        body.ContentFileName = ContentFileName;

    if (this.IsParameterBound(nameof(CreationDateTime)))
        body.CreationDateTime = CreationDateTime;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(RoleScopeTagIds)))
        body.RoleScopeTagIds = RoleScopeTagIds!.ToList();

    if (this.IsParameterBound(nameof(Version)))
        body.Version = Version;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.WindowsDefenderApplicationControlSupplementalPolicy? result;
            try
            {
                result = client.DeviceAppManagement.WdacSupplementalPolicies[WindowsDefenderApplicationControlSupplementalPolicyId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, WindowsDefenderApplicationControlSupplementalPolicyId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceAppManagement.WdacSupplementalPolicies[WindowsDefenderApplicationControlSupplementalPolicyId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, WindowsDefenderApplicationControlSupplementalPolicyId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
