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
  - remove-path-by-operation: teams_GetGroup|users\.joinedTeams.*|users_(Get|Update|Delete|Create)JoinedTeams|.*_UpdateInstalledApps|^teamwork\.teamTemplates\.definitions\.teamDefinition.*
# Remove cmdlets
  - where:
      verb: Remove
      subject: ^(Chat|TeamChannel|TeamPrimaryChannel)Message$
    remove: true
  - where:
      verb: Remove
      subject: ^(Chat|TeamChannel|TeamPrimaryChannel)MessageReply$
    remove: true
  - where:
      verb: Remove|Update
      subject: ^(Chat|TeamChannel|TeamPrimaryChannel)MessageHostedContent$
    remove: true
  - where:
      verb: Get
      subject: ^(TeamChannel|GroupTeamChannel)$
      variant: ^Get$|Get2|^GetViaIdentity$|GetViaIdentity2|^List$|List2
    set:
      subject: All$1
```
### Versioning

``` yaml
module-version: 1.12.3
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
