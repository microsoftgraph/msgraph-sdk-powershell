<!-- region Generated -->
# Microsoft.Graph.Identity.DirectoryRoleTemplates
This directory contains the PowerShell module for the IdentityDirectoryRoleTemplates service.

---
## Status
[![Microsoft.Graph.Identity.DirectoryRoleTemplates](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Identity.DirectoryRoleTemplates.svg?style=flat-square&label=Microsoft.Graph.Identity.DirectoryRoleTemplates "Microsoft.Graph.Identity.DirectoryRoleTemplates")](https://www.powershellgallery.com/packages/Microsoft.Graph.Identity.DirectoryRoleTemplates/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.Identity.DirectoryRoleTemplates`, see [how-to.md](how-to.md).
<!-- endregion -->

### AutoRest Configuration

> see https://aka.ms/autorest

``` yaml
require:
  - $(this-folder)/../../../readme.graph.md
title: $(service-name)
subject-prefix: ''
input-file: $(spec-doc-repo)/$(title).yml
directive:
# Rename cmdlets
  - where:
      verb: Get
      subject: (^DirectoryRoleTemplate$)
      variant: Get|GetExpanded
    set:
      verb: Get
      subject: $1ById
  - where:
      verb: Get|New|Remove|Update
      subject: (^DirectoryRoleTemplate)(DirectoryRoleTemplate.*)
    set:
      subject: $1
```
### Versioning

``` yaml
module-version: 0.2.2
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
