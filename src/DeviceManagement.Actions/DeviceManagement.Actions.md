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
  - remove-path-by-operation: ^deviceManagement.(userExperienceAnalyticsDeviceScope_.*|reusablePolicySettings.referencingConfigurationPolicies_(assign|createCopy)|deviceShellScripts.userRunStates.deviceRunStates.managedDevice_.*|windowsAutopilotDeploymentProfiles.(assignedDevices_updateDeviceProperties|assignedDevices.deploymentProfile_assign|assignedDevices.intendedDeploymentProfile_assign|assignedDevices_assignResourceAccountToDevice|assignedDevices_unassignResourceAccountFromDevice)|deviceComplianceScripts.deviceRunStates.managedDevice_.*|deviceCustomAttributeShellScripts.(deviceRunStates.managedDevice_.*|userRunStates.deviceRunStates.managedDevice_.*)|deviceManagementScripts.deviceRunStates.managedDevice(_updateWindowsDeviceAccount|_logoutSharedAppleDeviceActiveUser|_deleteUserFromSharedAppleDevice|_createDeviceLogCollectionRequest|_sendCustomNotificationToCompanyPortal|_triggerConfigurationManagerAction|_windowsDefenderUpdateSignatures)|deviceManagementScripts.userRunStates.deviceRunStates.managedDevice_.*|deviceConfigurations.groupAssignments.deviceConfiguration(_assignedAccessMultiModeProfiles|_windowsPrivacyAccessControls)|deviceHealthScripts.deviceRunStates.managedDevice(_sendCustomNotificationToCompanyPortal|_createDeviceLogCollectionRequest)|deviceShellScripts.deviceRunStates.managedDevice_sendCustomNotificationToCompanyPortal)$

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
