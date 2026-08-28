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
    [GraphRoute("POST", "/deviceAppManagement/mdmWindowsInformationProtectionPolicies")]
    [Cmdlet(VerbsCommon.New, "MgDeviceAppManagementMdmWindowsInformationProtectionPolicy", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.MdmWindowsInformationProtectionPolicy))]
    public class NewMgDeviceAppManagementMdmWindowsInformationProtectionPolicyCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Version { get; set; }

        [Parameter(Mandatory = false)]
        public bool? AzureRightsManagementServicesAllowed { get; set; }

        [Parameter(Mandatory = false)]
        public string? EnterpriseDomain { get; set; }

        [Parameter(Mandatory = false)]
        public bool? EnterpriseIPRangesAreAuthoritative { get; set; }

        [Parameter(Mandatory = false)]
        public bool? EnterpriseProxyServersAreAuthoritative { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IconsVisible { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IndexingEncryptedStoresOrItemsBlocked { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsAssigned { get; set; }

        [Parameter(Mandatory = false)]
        public bool? ProtectionUnderLockConfigRequired { get; set; }

        [Parameter(Mandatory = false)]
        public bool? RevokeOnUnenrollDisabled { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.Guid? RightsManagementServicesTemplateId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.WindowsInformationProtectionDataRecoveryCertificate? DataRecoveryCertificate { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.WindowsInformationProtectionEnforcementLevel? EnforcementLevel { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.WindowsInformationProtectionResourceCollection[]? EnterpriseInternalProxyServers { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.WindowsInformationProtectionIPRangeCollection[]? EnterpriseIPRanges { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.WindowsInformationProtectionResourceCollection[]? EnterpriseNetworkDomainNames { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.WindowsInformationProtectionResourceCollection[]? EnterpriseProtectedDomainNames { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.WindowsInformationProtectionProxiedDomainCollection[]? EnterpriseProxiedDomains { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.WindowsInformationProtectionResourceCollection[]? EnterpriseProxyServers { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.WindowsInformationProtectionApp[]? ExemptApps { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.WindowsInformationProtectionResourceCollection[]? NeutralDomainResources { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.WindowsInformationProtectionApp[]? ProtectedApps { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.WindowsInformationProtectionResourceCollection[]? SmbAutoEncryptedFileExtensions { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.MdmWindowsInformationProtectionPolicy();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(Version)))
        body.Version = Version;

    if (this.IsParameterBound(nameof(AzureRightsManagementServicesAllowed)))
        body.AzureRightsManagementServicesAllowed = AzureRightsManagementServicesAllowed;

    if (this.IsParameterBound(nameof(EnterpriseDomain)))
        body.EnterpriseDomain = EnterpriseDomain;

    if (this.IsParameterBound(nameof(EnterpriseIPRangesAreAuthoritative)))
        body.EnterpriseIPRangesAreAuthoritative = EnterpriseIPRangesAreAuthoritative;

    if (this.IsParameterBound(nameof(EnterpriseProxyServersAreAuthoritative)))
        body.EnterpriseProxyServersAreAuthoritative = EnterpriseProxyServersAreAuthoritative;

    if (this.IsParameterBound(nameof(IconsVisible)))
        body.IconsVisible = IconsVisible;

    if (this.IsParameterBound(nameof(IndexingEncryptedStoresOrItemsBlocked)))
        body.IndexingEncryptedStoresOrItemsBlocked = IndexingEncryptedStoresOrItemsBlocked;

    if (this.IsParameterBound(nameof(IsAssigned)))
        body.IsAssigned = IsAssigned;

    if (this.IsParameterBound(nameof(ProtectionUnderLockConfigRequired)))
        body.ProtectionUnderLockConfigRequired = ProtectionUnderLockConfigRequired;

    if (this.IsParameterBound(nameof(RevokeOnUnenrollDisabled)))
        body.RevokeOnUnenrollDisabled = RevokeOnUnenrollDisabled;

    if (this.IsParameterBound(nameof(RightsManagementServicesTemplateId)))
        body.RightsManagementServicesTemplateId = RightsManagementServicesTemplateId;

    if (this.IsParameterBound(nameof(DataRecoveryCertificate)))
        body.DataRecoveryCertificate = DataRecoveryCertificate;

    if (this.IsParameterBound(nameof(EnforcementLevel)))
        body.EnforcementLevel = EnforcementLevel;

    if (this.IsParameterBound(nameof(EnterpriseInternalProxyServers)))
        body.EnterpriseInternalProxyServers = EnterpriseInternalProxyServers!.ToList();

    if (this.IsParameterBound(nameof(EnterpriseIPRanges)))
        body.EnterpriseIPRanges = EnterpriseIPRanges!.ToList();

    if (this.IsParameterBound(nameof(EnterpriseNetworkDomainNames)))
        body.EnterpriseNetworkDomainNames = EnterpriseNetworkDomainNames!.ToList();

    if (this.IsParameterBound(nameof(EnterpriseProtectedDomainNames)))
        body.EnterpriseProtectedDomainNames = EnterpriseProtectedDomainNames!.ToList();

    if (this.IsParameterBound(nameof(EnterpriseProxiedDomains)))
        body.EnterpriseProxiedDomains = EnterpriseProxiedDomains!.ToList();

    if (this.IsParameterBound(nameof(EnterpriseProxyServers)))
        body.EnterpriseProxyServers = EnterpriseProxyServers!.ToList();

    if (this.IsParameterBound(nameof(ExemptApps)))
        body.ExemptApps = ExemptApps!.ToList();

    if (this.IsParameterBound(nameof(NeutralDomainResources)))
        body.NeutralDomainResources = NeutralDomainResources!.ToList();

    if (this.IsParameterBound(nameof(ProtectedApps)))
        body.ProtectedApps = ProtectedApps!.ToList();

    if (this.IsParameterBound(nameof(SmbAutoEncryptedFileExtensions)))
        body.SmbAutoEncryptedFileExtensions = SmbAutoEncryptedFileExtensions!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.MdmWindowsInformationProtectionPolicy? result;
            try
            {
                result = client.DeviceAppManagement.MdmWindowsInformationProtectionPolicies.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
