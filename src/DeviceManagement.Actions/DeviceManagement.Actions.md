# DeviceManagement.Actions

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for DeviceManagement.Actions v1.0 and/or beta modules.

## AutoRest Configuration

> see <https://aka.ms/autorest>

``` yaml
require:
  - $(this-folder)/../readme.graph.md
```

### Directives

> see https://github.com/Azure/autorest/blob/master/docs/powershell/directives.md

``` yaml
directive:
# Remove invalid paths that exceed Windows file name limit.
  - remove-path-by-operation: ^deviceManagement.(userExperienceAnalyticsDeviceScope_.*|reusablePolicySetting.referencingConfigurationPolicy_(assign|createCopy)|deviceShellScript.userRunState.deviceRunState.managedDevice_.*|windowsAutopilotDeploymentProfile.(assignedDevice_updateDeviceProperty|assignedDevice.deploymentProfile_assign|assignedDevice.intendedDeploymentProfile_assign|assignedDevice_assignResourceAccountToDevice|assignedDevice_unassignResourceAccountFromDevice)|deviceComplianceScript.deviceRunState.managedDevice_.*|deviceCustomAttributeShellScript.(deviceRunState.managedDevice_.*|userRunState.deviceRunState.managedDevice_.*)|deviceManagementScript.deviceRunState.managedDevice(_updateWindowsDeviceAccount|_logoutSharedAppleDeviceActiveUser|_deleteUserFromSharedAppleDevice|_createDeviceLogCollectionRequest|_sendCustomNotificationToCompanyPortal|_triggerConfigurationManagerAction|_windowsDefenderUpdateSignature)|deviceManagementScript.userRunState.deviceRunState.managedDevice_.*|deviceConfiguration.groupAssignment.deviceConfiguration(_assignedAccessMultiModeProfile|_windowsPrivacyAccessControl)|deviceHealthScript.deviceRunState.managedDevice(_sendCustomNotificationToCompanyPortal|_createDeviceLogCollectionRequest)|deviceShellScript.deviceRunState.managedDevice_sendCustomNotificationToCompanyPortal)|deviceManagement.microsoftTunnelSite.microsoftTunnelServer_generateServerLogCollectionRequest$|deviceManagement.reusablePolicySetting.referencingConfigurationPolicy_clearEnrollmentTimeDeviceMembershipTarget$|deviceManagement.reusablePolicySetting.referencingConfigurationPolicy_retrieveEnrollmentTimeDeviceMembershipTarget$

# Remove cmdlets.
  - where:
      verb: Get
      subject: ^DeviceManagementReportCertificateReport$
    remove: true
  - where:
      verb: New
      subject: ^DeviceManagementComanagedDeviceLogCollectionRequest$
    remove: true
  - where:
      verb: Update
      subject: ^DeviceManagementComanagedDevice.*
    remove: true
  - where:
      verb: Test
      subject: ^DeviceManagementAssignmentFilter$
      variant: ^Evaluate.*
    remove: true

# Rename cmdlets.
  - where:
      verb: Get
      subject: ^(DeviceManagementDeviceConfiguration)$
      variant: ^Access$|^AccessExpanded$|^AccessViaIdentity$|^AccessViaIdentityExpanded$
    set:
      verb: Invoke
      subject: $1AssignedAccessMultiModeProfile
  - where:
      verb: Get
      subject: ^(DeviceManagementDeviceConfiguration)$
      variant: ^Access1$|^AccessExpanded1$|^AccessViaIdentity1$|^AccessViaIdentityExpanded1$
    set:
      verb: Invoke
      subject: $1WindowsPrivacyAccessControl
  - where:
      verb: Update
      subject: ^(DeviceManagementGroupPolicyConfiguration)(DefinitionValue)$
    set:
      subject: $1Multiple$2
  - where:
      verb: Update
      subject: ^(DeviceManagementIntent)(Setting)$
    set:
      subject: $1Multiple$2
  - where:
      verb: Remove
      subject: ^(DeviceManagementWindowAutopilotDeploymentProfile)(AssignedDevice)$
    set:
      subject: $1Multiple$2
  - where:
      verb: Update
      subject: ^(DeviceManagementManagedDevice)$
    set:
      verb: New
      subject: $1WindowsDefenderUpdateSignature
  - where:
      verb: Invoke
      subject: ^Bulk(DeviceManagementManagedDevice)RestoreCloudPc$
    set:
      subject: BulkRestore$1CloudPc
  - where:
      verb: Invoke
      subject: ^Bulk(DeviceManagementComanagedDevice)RestoreCloudPc$
    set:
      subject: BulkRestore$1CloudPc
  - where:
      verb: Invoke
      subject: ^Bulk(DeviceManagementDetectedAppManagedDevice)RestoreCloudPc$
    set:
      subject: BulkRestore$1CloudPc
  - where:
      verb: Invoke
      subject: ^Bulk(DeviceManagementComanagedDevice)ReprovisionCloudPc$
    set:
      subject: BulkReprovision$1CloudPc
  - where:
      verb: Invoke
      subject: ^Bulk(DeviceManagementDetectedAppManagedDevice)ReprovisionCloudPc$
    set:
      subject: BulkReprovision$1CloudPc
  - where:
      verb: Invoke
      subject: ^Bulk(DeviceManagementManagedDevice)ReprovisionCloudPc$
    set:
      subject: BulkReprovision$1CloudPc
  - where:
      verb: Invoke
      subject: ^Cloud(DeviceManagementDeviceHealthScriptDeviceRunStateManagedDevice)$
    set:
      subject: Reprovision$1CloudPc
  - where:
      verb: Invoke
      subject: ^Cloud(DeviceManagementDeviceShellScriptDeviceRunStateManagedDevice)$
    set:
      subject: Reprovision$1CloudPc
  - where:
      verb: Invoke
      subject: ^Cloud(DeviceManagementScriptDeviceRunStateManagedDevice)$
    set:
      subject: Reprovision$1CloudPc
  - where:
      verb: Invoke
      subject: ^Cloud(DeviceManagementComanagedDevice)$
    set:
      subject: Reprovision$1CloudPc
  - where:
      verb: Invoke
      subject: ^Cloud(DeviceManagementManagedDevice)$
    set:
      subject: Reprovision$1CloudPc
```
