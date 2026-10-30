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
# Wrapper migration: directive 1 is bridged from the COMPLETE original legacy
# regex set (v1.0: 337; beta: 9), not from renamed compatible operation IDs.
# Teams_directiveMigrationMap.json records every surviving exact operation.
# Compatible IDs now align with the original complete selector sets; tests retain
# kind-guarded final action/function source lineage. No removals are claimed.
# Teams_cmdletConfigurations.cs preserves joinedTeams list and unrelated roots;
# user.joinedTeam_GetCount matches the original regex and is suppressed.
  - remove-path-by-operation: ^(team_GetGroup|user\.joinedTeam.*|user_(Get|Update|Delete|Create)JoinedTeam|.*_UpdateInstalledApp)$
# Remove cmdlets
# Wrapper migration: directives 2-4 suppress only the selected verb and exact
# message/reply/direct-hosted-content subjects. Reply hosted contents and group
# navigations are not additional matches. TeamsDirectiveMigrationTests pins neighbors.
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
# Wrapper migration: directive 5 suppresses the TeamDefinition node (beta only),
# not its descendants: the original [A-Z]* suffix does not mean an arbitrary subtree.
  - where:
      subject: (.*)TeamworkTeamTemplateDefinitionTeamDefinition([A-Z]*)$
    remove: true
# Rename AllChannel due to https://github.com/Azure/autorest.powershell/issues/1002.
# Wrapper migration: directives 6-9 have exact compatible operation evidence in
# the adjacent ledger. Curated fallbacks cover beta; existing v1.0 derived names
# remain authoritative. Ordinary channels and non-GET message operations keep names.
# Directive 9 includes the distinct getAllMessages() URL as well as list/item GET.
# The function has a different request/response contract and is not a compatible
# natural-ID variant. Its explicit noun is AllUserChatMessageAcrossChat, from
# the source description "all messages from all chats"; ordinary List/Get remains.
# Frozen v1 derived suppression still omits that function; no module rule prunes it.
# This baseline limitation is not a faithful three-route/default or raw parity pass.
# No OnlineMeetingTranscript/Recording subjects occur in either Teams spec.
# Keep all shared AutoRest directives active. Profile-local readmes and
# src/readme.graph.md are ignored; parameter/schema aliases/transforms are deferred.
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
