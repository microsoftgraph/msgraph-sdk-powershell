<!-- region Generated -->
# Microsoft.Graph.Identity.DirectorySettingTemplates
This directory contains the PowerShell module for the IdentityDirectorySettingTemplates service.

---
## Status
[![Microsoft.Graph.Identity.DirectorySettingTemplates](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Identity.DirectorySettingTemplates.svg?style=flat-square&label=Microsoft.Graph.Identity.DirectorySettingTemplates "Microsoft.Graph.Identity.DirectorySettingTemplates")](https://www.powershellgallery.com/packages/Microsoft.Graph.Identity.DirectorySettingTemplates/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.Identity.DirectorySettingTemplates`, see [how-to.md](how-to.md).
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
      subject: (^DirectorySettingTemplate$)
      variant: Get|GetExpanded
    set:
      verb: Get
      subject: $1ById
  - where:
      verb: Get|New|Remove|Update
      subject: (^DirectorySettingTemplate)(DirectorySettingTemplate.*)
    set:
      subject: $1
```
### Versioning

``` yaml
module-version: 0.3.0
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
