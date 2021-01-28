<!-- region Generated -->
# Microsoft.Graph.Identity.DirectoryManagement
This directory contains the PowerShell module for the IdentityDirectory service.

---
## Status
[![Microsoft.Graph.Identity.DirectoryManagement](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Identity.DirectoryManagement.svg?style=flat-square&label=Microsoft.Graph.Identity.DirectoryManagement "Microsoft.Graph.Identity.DirectoryManagement")](https://www.powershellgallery.com/packages/Microsoft.Graph.Identity.DirectoryManagement/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.Identity.DirectoryManagement`, see [how-to.md](how-to.md).
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
  - where:
      verb: Get
      subject: (^DirectorySettingTemplate$)
      variant: Get|GetExpanded
    set:
      verb: Get
      subject: $1ById
  - where:
      verb: Get
      subject: (^DirectoryRoleTemplate$)
      variant: Get|GetExpanded|Get1|GetExpanded1
    set:
      verb: Get
      subject: $1ById
# Rename cmdlets with duplicates in their name.
  - where:
      subject: ^(DirectorySettingTemplate|DirectoryRoleTemplate)(\1)+
    set:
      subject: $1
# Rename cmdlets
  - where:
      verb: Get
      subject: (^AdministrativeUnit$)
      variant: Get1|GetExpanded
    set:
      subject: $1ById
  - where:
      verb: Get
      subject: (^Contact$)
    set:
      subject: $1ById
  - where:
      subject: (^Contact)(OrgContact$)
    set:
      subject: $1
  - where:
      verb: Get
      subject: (^Device$)
      variant: Get|GetExpanded|Get2|GetExpanded1
    set:
      verb: Get
      subject: $1ById
  - where:
      verb: Get
      subject: (^DirectoryRole$)
      variant: Get1|GetExpanded|Get3|GetExpanded1
    set:
      verb: Get
      subject: $1ById
  - where:
      subject: ^(Setting)(DirectorySetting)$
    set:
      subject: $2
  - where:
      verb: Get
      subject: (^Contract$)
      variant: Get1|GetExpanded|Get3|GetExpanded1
    set:
      verb: Get
      subject: $1ById
  - where:
      verb: Get
      subject: (^Organization$)
      variant: Get1|GetExpanded|Get3|GetExpanded1
    set:
      verb: Get
      subject: $1ById
```
### Versioning

``` yaml
module-version: 1.3.0
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
