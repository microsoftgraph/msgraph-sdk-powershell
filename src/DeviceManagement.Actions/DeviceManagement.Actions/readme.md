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
# Remove invalid paths.
  - remove-path-by-operation: ^deviceManagement.(deviceShellScripts.userRunStates.deviceRunStates.managedDevice(_setDeviceName|_triggerConfigurationManagerAction|_updateWindowsDeviceAccount|_windowsDefenderUpdateSignatures|_windowsDefenderScan|_wipe)|windowsAutopilotDeploymentProfiles.(assignedDevices_updateDeviceProperties|assignedDevices.deploymentProfile_assign|assignedDevices.intendedDeploymentProfile_assign|assignedDevices_assignResourceAccountToDevice|assignedDevices_unassignResourceAccountFromDevice)|deviceComplianceScripts.deviceRunStates.managedDevice_sendCustomNotificationToCompanyPortal|deviceCustomAttributeShellScripts.(deviceRunStates.managedDevice_.*|userRunStates.deviceRunStates.managedDevice_.*)|deviceManagementScripts.deviceRunStates.managedDevice(_updateWindowsDeviceAccount|_logoutSharedAppleDeviceActiveUser|_deleteUserFromSharedAppleDevice|_createDeviceLogCollectionRequest|_sendCustomNotificationToCompanyPortal|_triggerConfigurationManagerAction|_windowsDefenderUpdateSignatures)|deviceManagementScripts.userRunStates.deviceRunStates.managedDevice_.*|deviceShellScripts.userRunStates.deviceRunStates.managedDevice_.*|deviceComplianceScripts.deviceRunStates.managedDevice_.*|deviceConfigurations.groupAssignments.deviceConfiguration(_assignedAccessMultiModeProfiles|_windowsPrivacyAccessControls)|deviceHealthScripts.deviceRunStates.managedDevice(_sendCustomNotificationToCompanyPortal|_createDeviceLogCollectionRequest)|deviceShellScripts.deviceRunStates.managedDevice_sendCustomNotificationToCompanyPortal)$

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
```

### Versioning

``` yaml
module-version: 1.3.0
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
