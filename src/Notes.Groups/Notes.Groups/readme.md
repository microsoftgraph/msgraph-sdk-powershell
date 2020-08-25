<!-- region Generated -->
# Microsoft.Graph.Notes.Groups
This directory contains the PowerShell module for the NotesGroups service.

---
## Status
[![Microsoft.Graph.Notes.Groups](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Notes.Groups.svg?style=flat-square&label=Microsoft.Graph.Notes.Groups "Microsoft.Graph.Notes.Groups")](https://www.powershellgallery.com/packages/Microsoft.Graph.Notes.Groups/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.Notes.Groups`, see [how-to.md](how-to.md).
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
  - remove-path-by-operation: ^groups_.*Onenote$|.*\.onenote\..*parent.*|.*\.notebooks_(Get|Update|Delete)Section.*|.*\.notebooks\.section.*|.*\.sectionGroups_(Get|Update|Delete)Section.*|.*\.sectionGroups\.section.*|.*\.sections_(Get|Update|Delete)Pages|.*\.sections.pages.*|.*\.onenote_(List|Create|Update|Delete)(Operations|Resources)

```
### Versioning

``` yaml
module-version: 0.9.2
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
