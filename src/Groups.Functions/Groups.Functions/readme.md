<!-- region Generated -->
# Microsoft.Graph.Groups.Functions
This directory contains the PowerShell module for the GroupsFunctions service.

---
## Status
[![Microsoft.Graph.Groups.Functions](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Groups.Functions.svg?style=flat-square&label=Microsoft.Graph.Groups.Functions "Microsoft.Graph.Groups.Functions")](https://www.powershellgallery.com/packages/Microsoft.Graph.Groups.Functions/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.Groups.Functions`, see [how-to.md](how-to.md).
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
# Remove paths that have /parent* or /calendarView*.
  - remove-path-by-operation: groups.onenote\..*parent.*|groups.*.calendarView.*|.*.notebooks.section.*|.*.sectionGroups.section.*|.*.sections.pages.*|groups.calendar.events\..*$|groups.events\..*$
# Rename cmdlets.
  - where:
      verb: Get
      subject: ^(GroupOnenote)Notebook(RecentNotebook)$
    set:
      subject: $1$2
```
### Versioning

``` yaml
module-version: 0.9.2
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
