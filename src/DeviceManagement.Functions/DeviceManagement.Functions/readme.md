<!-- region Generated -->
# Microsoft.Graph.DeviceManagement.Functions
This directory contains the PowerShell module for the DeviceFunctions service.

---
## Status
[![Microsoft.Graph.DeviceManagement.Functions](https://img.shields.io/powershellgallery/v/Microsoft.Graph.DeviceManagement.Functions.svg?style=flat-square&label=Microsoft.Graph.DeviceManagement.Functions "Microsoft.Graph.DeviceManagement.Functions")](https://www.powershellgallery.com/packages/Microsoft.Graph.DeviceManagement.Functions/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.DeviceManagement.Functions`, see [how-to.md](how-to.md).
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
# Rename cmdlets.
  - where:
      subject: ^(DeviceManagement(Condition|ConditionStatementManagementCondition|ConditionStatementManagementConditionStatement))$
    set:
      subject: $1ForPlatform
  - where:
      subject: ^(DeviceManagementRoleScopeTag)$
      variant: ^Get$
    set:
      subject: $1ById
  - where:
      subject: ^(DeviceManagementRoleScopeTag)$
      variant: ^Get1$|^GetViaIdentity$
    set:
      subject: $1ByResource
```
### Versioning

``` yaml
module-version: 1.4.3
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
