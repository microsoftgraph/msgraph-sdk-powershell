# Teams

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for Teams v1.0 and/or beta modules.

## AutoRest Configuration

> see <https://aka.ms/autorest>

``` yaml
require:
  - $(this-folder)/../readme.graph.md
```

### Directives

> see https://github.com/Azure/autorest/blob/master/docs/powershell/directives.md

``` yaml
directive:
# Remove invalid paths.
  - remove-path-by-operation: teams_GetGroup|users\.joinedTeams.*|users_(Get|Update|Delete|Create)JoinedTeams|.*_UpdateInstalledApps
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
```
