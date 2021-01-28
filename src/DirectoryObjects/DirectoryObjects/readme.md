<!-- region Generated -->
# Microsoft.Graph.DirectoryObjects
This directory contains the PowerShell module for the DirectoryObjects service.

---
## Status
[![Microsoft.Graph.DirectoryObjects](https://img.shields.io/powershellgallery/v/Microsoft.Graph.DirectoryObjects.svg?style=flat-square&label=Microsoft.Graph.DirectoryObjects "Microsoft.Graph.DirectoryObjects")](https://www.powershellgallery.com/packages/Microsoft.Graph.DirectoryObjects/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.DirectoryObjects`, see [how-to.md](how-to.md).
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
      subject: (^DirectoryObject$)
      variant: ^(Get|Get3|GetExpanded|GetExpanded1)$
    set:
      verb: Get
      subject: $1ById
  - where:
      subject: (^DirectoryObject)MicrosoftGraph(AdministrativeUnitDelta$)
    set:
      subject: $1$2
```
### Versioning

``` yaml
module-version: 1.3.0
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
