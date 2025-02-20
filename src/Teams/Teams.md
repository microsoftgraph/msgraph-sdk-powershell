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
  - remove-path-by-operation: ^(team_GetGroup|user\.joinedTeam.*|user_(Get|Update|Delete|Create)JoinedTeam|.*_UpdateInstalledApp)$
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
      subject: (.*)TeamworkTeamTemplateDefinitionTeamDefinition([A-Z]*)$
    remove: true
# Rename AllChannel due to https://github.com/Azure/autorest.powershell/issues/1002.
  - where:
      verb: Get
      subject: ^(TeamMessage|TeamworkDeletedTeamMessage)$
    set:
      subject: All$1
  - where:
      verb: Get
      variant: ^Get$|^GetViaIdentity$|^List$
      subject: ^(TeamChannel|GroupTeamChannel)$
    set:
      subject: All$1
  - where:
      verb: Get
      subject: ^(Team|GroupTeam)All(ChannelCount)$
    set:
      subject: All$1$2
  - where:
      verb: Get
      subject: ^(User)(ChatMessage|OnlineMeetingTranscript|OnlineMeetingRecording)$
    set:
      subject: All$1$2
```
