<!-- region Generated -->
# Microsoft.Graph.DeviceManagement
This directory contains the PowerShell module for the Device service.

---
## Status
[![Microsoft.Graph.DeviceManagement](https://img.shields.io/powershellgallery/v/Microsoft.Graph.DeviceManagement.svg?style=flat-square&label=Microsoft.Graph.DeviceManagement "Microsoft.Graph.DeviceManagement")](https://www.powershellgallery.com/packages/Microsoft.Graph.DeviceManagement/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.DeviceManagement`, see [how-to.md](how-to.md).
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
  - remove-path-by-operation: ^deviceManagement.(deviceManagementScripts.userRunStates.deviceRunStates_SetRefManagedDevice|groupPolicyConfigurations.definitionValues.presentationValues_SetRefDefinitionValue|groupPolicyConfigurations.definitionValues.presentationValues_SetRefPresentation|deviceShellScripts.userRunStates.deviceRunStates_SetRefManagedDevice)$

# Remove cmdlets.
  - where:
      verb: New
      subject: ^DeviceManagement(Managed|Comanaged)DeviceLogCollectionRequest$
    remove: true
  - where:
      verb: Update
      subject: ^DeviceManagementComanagedDevice$
    remove: true

# Rename cmdlets.
  - where:
      subject: ^(DeviceManagementUserExperienceAnalyticAppHealthApplicationPerformance)$
      variant: ^Create1$|^CreateExpanded1$|^Get1$|^GetViaIdentity1$|^List1$|^Delete1$|^DeleteViaIdentity1$|^Update1$|^UpdateExpanded1$|^UpdateViaIdentity1$|^UpdateViaIdentityExpanded1$
    set:
      subject: $1ByAppVersion
  - where:
      subject: ^(DeviceManagementUserExperienceAnalyticAppHealthApplicationPerformance)$
      variant: ^Create2$|^CreateExpanded2$|^Get2$|^GetViaIdentity2$|^List2$|^Delete2$|^DeleteViaIdentity2$|^Update2$|^UpdateExpanded2$|^UpdateViaIdentity2$|^UpdateViaIdentityExpanded2$
    set:
      subject: $1ByOSVersion

  - where:
      subject: ^(DeviceManagementAndroid)$
      variant: ^Create$|^CreateExpanded$|^Get$|^GetViaIdentity$|^List$|^Delete$|^DeleteViaIdentity$|^Update$|^UpdateExpanded$|^UpdateViaIdentity$|^UpdateViaIdentityExpanded$
    set:
      subject: $1ForWorkAppConfigurationSchema
  - where:
      subject: ^(DeviceManagementAndroid)$
      variant: ^Get1$|^Delete1$|^Update1$|^UpdateExpanded1$
    set:
      subject: $1ForWorkSetting
```
### Versioning

``` yaml
module-version: 1.4.0
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
