<!-- region Generated -->
# Microsoft.Graph.Teams.Team
This directory contains the PowerShell module for the TeamsTeam service.

---
## Status
[![Microsoft.Graph.Teams.Team](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Teams.Team.svg?style=flat-square&label=Microsoft.Graph.Teams.Team "Microsoft.Graph.Teams.Team")](https://www.powershellgallery.com/packages/Microsoft.Graph.Teams.Team/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.Teams.Team`, see [how-to.md](how-to.md).
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
  - remove-path-by-operation: teams_GetGroup|team_ListTeam
```

### Versioning

``` yaml
module-version: 0.9.2
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
