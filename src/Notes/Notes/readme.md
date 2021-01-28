<!-- region Generated -->
# Microsoft.Graph.Notes
This directory contains the PowerShell module for the Notes service.

---
## Status
[![Microsoft.Graph.Notes](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Notes.svg?style=flat-square&label=Microsoft.Graph.Notes "Microsoft.Graph.Notes")](https://www.powershellgallery.com/packages/Microsoft.Graph.Notes/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.Notes`, see [how-to.md](how-to.md).
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
# Remove paths that are not valid.
  - remove-path-by-operation: ^(users|groups|sites)_.*Onenote$|.*\.onenote\..*parent.*|.*\.notebooks_(Get|Update|Delete)Section.*|.*\.notebooks\.section.*|.*\.sectionGroups_(Get|Update|Delete)Section.*|.*\.sectionGroups\.section.*|.*\.sections_(Get|Update|Delete)Pages|.*\.sections.pages.*|.*\.onenote_(List|Create|Update|Delete)(Operations|Resources)
```
### Versioning

``` yaml
module-version: 1.3.0
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
