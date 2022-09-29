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
  - remove-path-by-operation: ^deviceManagement.(deviceManagementScripts.userRunStates.deviceRunStates_.*|groupPolicyConfigurations.definitionValues.presentationValues_.*|deviceShellScripts.userRunStates.deviceRunStates_.*)$

# Remove cmdlets.
  - where:
      verb: New
      subject: ^DeviceManagement(Managed|Comanaged)DeviceLogCollectionRequest$
    remove: true
  - where:
      verb: Update
      subject: ^DeviceManagementComanagedDevice$
    remove: true
```
### Versioning

``` yaml
module-version: 1.12.2
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
