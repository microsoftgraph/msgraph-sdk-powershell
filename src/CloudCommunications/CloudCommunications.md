# CloudCommunications

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for CloudCommunications v1.0 and/or beta modules.

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
  - remove-path-by-operation: ^communications(.cloudCommunications_.*CloudCommunications|_(List|Create|Update|Delete)CallRecords|.callRecords.sessions_.*Segments|(_List|_Update)Calls)$
# Rename cmdlets
  - where:
      verb: Invoke
      subject: ^Mute(CommunicationCallParticipant)$
      variant: ^Mute1$|^MuteExpanded1$|^MuteViaIdentity1$|^MuteViaIdentityExpanded1$
    set:
      subject: MuteAll$1
  - where:
      verb: New
      subject: ^(CommunicationOnlineMeeting)$
      variant: ^Create1$|^CreateExpanded1$
    set:
      verb: Invoke
      subject: CreateOrGet$1
```

### Versioning

``` yaml
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
