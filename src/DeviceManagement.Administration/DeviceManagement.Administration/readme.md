<!-- region Generated -->
# Microsoft.Graph.DeviceManagement.Administration
This directory contains the PowerShell module for the DeviceAdministration service.

---
## Status
[![Microsoft.Graph.DeviceManagement.Administration](https://img.shields.io/powershellgallery/v/Microsoft.Graph.DeviceManagement.Administration.svg?style=flat-square&label=Microsoft.Graph.DeviceManagement.Administration "Microsoft.Graph.DeviceManagement.Administration")](https://www.powershellgallery.com/packages/Microsoft.Graph.DeviceManagement.Administration/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.DeviceManagement.Administration`, see [how-to.md](how-to.md).
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
# Pluralize
  - where:
      subject: (.*)OnPremisConnection(.*)
    set:
      subject: $1OnPremisesConnection$2
# Remove cmdlets.
  - where:
      verb: New
      subject: ^DeviceManagementGroupPolicyMigrationReport$
    remove: true
  - where:
      verb: Remove
      subject: ^DeviceManagementGroupPolicyUploadedDefinitionFile$
    remove: true
  - where:
      verb: New|Remove|Update
      subject: ^DeviceManagementVirtualEndpoint(AuditEvent|CloudPC|AuditEventAuditActivityType|DeviceImageSourceImage)$
    remove: true
  - where:
      verb: New|Remove|Update
      subject: ^DeviceManagementVirtualEndpoint$
    remove: true
```
### Versioning

``` yaml
module-version: 1.9.6
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
