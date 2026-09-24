#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DeviceManagement.Client;
using Microsoft.Graph.PowerShell.DeviceManagement.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement
{
    [GraphRoute("PATCH", "/deviceManagement/androidManagedStoreAccountEnterpriseSettings")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementAndroidManagedStoreAccountEnterpriseSetting", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.AndroidManagedStoreAccountEnterpriseSettings))]
    public class UpdateMgDeviceManagementAndroidManagedStoreAccountEnterpriseSettingCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public bool? AndroidDeviceOwnerFullyManagedEnrollmentEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? DeviceOwnerManagementEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastAppSyncDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? ManagedGooglePlayInitialScopeTagIds { get; set; }

        [Parameter(Mandatory = false)]
        public string? OwnerOrganizationName { get; set; }

        [Parameter(Mandatory = false)]
        public string? OwnerUserPrincipalName { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? TargetGroupIds { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.AndroidManagedStoreAccountBindStatus? BindStatus { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.AndroidEnrollmentCompanyCode[]? CompanyCodes { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.AndroidManagedStoreAccountEnrollmentTarget? EnrollmentTarget { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.AndroidManagedStoreAccountAppSyncStatus? LastAppSyncStatus { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ManagedGooglePlayEnterpriseType? ManagedGooglePlayEnterpriseType { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.AndroidManagedStoreAccountEnterpriseSettings();

    if (this.IsParameterBound(nameof(AndroidDeviceOwnerFullyManagedEnrollmentEnabled)))
        body.AndroidDeviceOwnerFullyManagedEnrollmentEnabled = AndroidDeviceOwnerFullyManagedEnrollmentEnabled;

    if (this.IsParameterBound(nameof(DeviceOwnerManagementEnabled)))
        body.DeviceOwnerManagementEnabled = DeviceOwnerManagementEnabled;

    if (this.IsParameterBound(nameof(LastAppSyncDateTime)))
        body.LastAppSyncDateTime = LastAppSyncDateTime;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(ManagedGooglePlayInitialScopeTagIds)))
        body.ManagedGooglePlayInitialScopeTagIds = ManagedGooglePlayInitialScopeTagIds!.ToList();

    if (this.IsParameterBound(nameof(OwnerOrganizationName)))
        body.OwnerOrganizationName = OwnerOrganizationName;

    if (this.IsParameterBound(nameof(OwnerUserPrincipalName)))
        body.OwnerUserPrincipalName = OwnerUserPrincipalName;

    if (this.IsParameterBound(nameof(TargetGroupIds)))
        body.TargetGroupIds = TargetGroupIds!.ToList();

    if (this.IsParameterBound(nameof(BindStatus)))
        body.BindStatus = BindStatus;

    if (this.IsParameterBound(nameof(CompanyCodes)))
        body.CompanyCodes = CompanyCodes!.ToList();

    if (this.IsParameterBound(nameof(EnrollmentTarget)))
        body.EnrollmentTarget = EnrollmentTarget;

    if (this.IsParameterBound(nameof(LastAppSyncStatus)))
        body.LastAppSyncStatus = LastAppSyncStatus;

    if (this.IsParameterBound(nameof(ManagedGooglePlayEnterpriseType)))
        body.ManagedGooglePlayEnterpriseType = ManagedGooglePlayEnterpriseType;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.AndroidManagedStoreAccountEnterpriseSettings? result;
            try
            {
                result = client.DeviceManagement.AndroidManagedStoreAccountEnterpriseSettings.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.AndroidManagedStoreAccountEnterpriseSettings.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
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
