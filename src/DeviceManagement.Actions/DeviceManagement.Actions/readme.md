<!-- region Generated -->
# Microsoft.Graph.DeviceManagement.Actions
This directory contains the PowerShell module for the DeviceActions service.

---
## Status
[![Microsoft.Graph.DeviceManagement.Actions](https://img.shields.io/powershellgallery/v/Microsoft.Graph.DeviceManagement.Actions.svg?style=flat-square&label=Microsoft.Graph.DeviceManagement.Actions "Microsoft.Graph.DeviceManagement.Actions")](https://www.powershellgallery.com/packages/Microsoft.Graph.DeviceManagement.Actions/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.DeviceManagement.Actions`, see [how-to.md](how-to.md).
<!-- endregion -->

### AutoRest Configuration

> see https://aka.ms/autorest

``` yaml
require:
  - $(this-folder)/../../readme.graph.md
  - $(this-folder)/../../../profiles/$(title)/readme.md
title: $(service-name)
subject-prefix: ''
```

### Directives

> see https://github.com/Azure/autorest/blob/master/docs/powershell/directives.md

``` yaml
directive:
# Remove invalid paths that exceed Windows file name limit.
  - remove-path-by-operation: ^deviceManagement.(userExperienceAnalyticsDeviceScopes_.*|reusablePolicySettings.referencingConfigurationPolicies_(assign|createCopy)|deviceShellScripts.userRunStates.deviceRunStates.managedDevice_.*|windowsAutopilotDeploymentProfiles.(assignedDevices_updateDeviceProperties|assignedDevices.deploymentProfile_assign|assignedDevices.intendedDeploymentProfile_assign|assignedDevices_assignResourceAccountToDevice|assignedDevices_unassignResourceAccountFromDevice)|deviceComplianceScripts.deviceRunStates.managedDevice_.*|deviceCustomAttributeShellScripts.(deviceRunStates.managedDevice_.*|userRunStates.deviceRunStates.managedDevice_.*)|deviceManagementScripts.deviceRunStates.managedDevice(_updateWindowsDeviceAccount|_logoutSharedAppleDeviceActiveUser|_deleteUserFromSharedAppleDevice|_createDeviceLogCollectionRequest|_sendCustomNotificationToCompanyPortal|_triggerConfigurationManagerAction|_windowsDefenderUpdateSignatures)|deviceManagementScripts.userRunStates.deviceRunStates.managedDevice_.*|deviceConfigurations.groupAssignments.deviceConfiguration(_assignedAccessMultiModeProfiles|_windowsPrivacyAccessControls)|deviceHealthScripts.deviceRunStates.managedDevice(_sendCustomNotificationToCompanyPortal|_createDeviceLogCollectionRequest)|deviceShellScripts.deviceRunStates.managedDevice_sendCustomNotificationToCompanyPortal)|deviceManagement.microsoftTunnelSites.microsoftTunnelServers_generateServerLogCollectionRequest$

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
      alias: Invoke-MgBulkDeviceManagementManagedDeviceRestoreCloudPc
  - where:
      verb: Invoke
      subject: ^Bulk(DeviceManagementComanagedDevice)RestoreCloudPc$
    set:
      subject: BulkRestore$1CloudPc
      alias: Invoke-MgBulkDeviceManagementComanagedDeviceRestoreCloudPc
  - where:
      verb: Invoke
      subject: ^Bulk(DeviceManagementDetectedAppManagedDevice)RestoreCloudPc$
    set:
      subject: BulkRestore$1CloudPc
      alias: Invoke-MgBulkDeviceManagementDetectedAppManagedDeviceRestoreCloudPc
  - where:
      verb: Invoke
      subject: ^Bulk(DeviceManagementComanagedDevice)ReprovisionCloudPc$
    set:
      subject: BulkReprovision$1CloudPc
      alias: Invoke-MgBulkDeviceManagementComanagedDeviceReprovisionCloudPc
  - where:
      verb: Invoke
      subject: ^Bulk(DeviceManagementDetectedAppManagedDevice)ReprovisionCloudPc$
    set:
      subject: BulkReprovision$1CloudPc
      alias: Invoke-MgBulkDeviceManagementDetectedAppManagedDeviceReprovisionCloudPc
  - where:
      verb: Invoke
      subject: ^Bulk(DeviceManagementManagedDevice)ReprovisionCloudPc$
    set:
      subject: BulkReprovision$1CloudPc
      alias: Invoke-MgBulkDeviceManagementManagedDeviceReprovisionCloudPc
  - where:
      verb: Invoke
      subject: ^Cloud(DeviceManagementDeviceHealthScriptDeviceRunStateManagedDevice)$
    set:
      subject: Reprovision$1CloudPc
      alias: Invoke-MgCloudDeviceManagementDeviceHealthScriptDeviceRunStateManagedDevice
  - where:
      verb: Invoke
      subject: ^Cloud(DeviceManagementDeviceShellScriptDeviceRunStateManagedDevice)$
    set:
      subject: Reprovision$1CloudPc
      alias: Invoke-MgCloudDeviceManagementDeviceShellScriptDeviceRunStateManagedDevice
  - where:
      verb: Invoke
      subject: ^Cloud(DeviceManagementScriptDeviceRunStateManagedDevice)$
    set:
      subject: Reprovision$1CloudPc
      alias: Invoke-MgCloudDeviceManagementScriptDeviceRunStateManagedDevice
  - where:
      verb: Invoke
      subject: ^Cloud(DeviceManagementComanagedDevice)$
    set:
      subject: Reprovision$1CloudPc
      alias: Invoke-MgCloudDeviceManagementComanagedDevice
  - where:
      verb: Invoke
      subject: ^Cloud(DeviceManagementManagedDevice)$
    set:
      subject: Reprovision$1CloudPc
      alias: Invoke-MgCloudDeviceManagementManagedDevice
```
### Versioning

``` yaml
module-version: 1.13.0
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
