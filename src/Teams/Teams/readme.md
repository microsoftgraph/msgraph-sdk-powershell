<!-- region Generated -->
# Microsoft.Graph.Teams
This directory contains the PowerShell module for the Teams service.

---
## Status
[![Microsoft.Graph.Teams](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Teams.svg?style=flat-square&label=Microsoft.Graph.Teams "Microsoft.Graph.Teams")](https://www.powershellgallery.com/packages/Microsoft.Graph.Teams/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.Teams`, see [how-to.md](how-to.md).
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
# Remove invalid paths.
  - remove-path-by-operation: teams_GetGroup|team_ListTeam
```
### Versioning

``` yaml
module-version: 1.3.0
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
