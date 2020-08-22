<!-- region Generated -->
# Microsoft.Graph.Identity.PIM
This directory contains the PowerShell module for the IdentityPim service.

---
## Status
[![Microsoft.Graph.Identity.PIM](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Identity.PIM.svg?style=flat-square&label=Microsoft.Graph.Identity.PIM "Microsoft.Graph.Identity.PIM")](https://www.powershellgallery.com/packages/Microsoft.Graph.Identity.PIM/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.Identity.PIM`, see [how-to.md](how-to.md).
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
# Rename cmdlets
  - where:
      verb: Get
      subject: ^(PrivilegedRole)(Assignment)$
    set:
      subject: $1Role$2
# Rename cmdlets with duplicates in their name.
  - where:
      subject: ^(PrivilegedRoleAssignment)(\1)+
    set:
      subject: $1
  - where:
      subject: ^(PrivilegedRoleAssignmentRequest)(\1)+
    set:
      subject: $1
  - where:
      subject: ^(PrivilegedOperationEvent)(\1)+
    set:
      subject: $1
```
### Versioning

``` yaml
module-version: 0.9.2
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
