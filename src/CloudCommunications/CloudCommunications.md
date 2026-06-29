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
  - remove-path-by-operation: ^communication(.cloudCommunication_.*CloudCommunication|_(List|Create|Update|Delete)CallRecord|.callRecord.session_.*Segment|(_List|_Update)Call)$
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
  - where:
      verb: New
      subject: ^UserOnlineMeeting$
      variant: ^(Create|CreateExpanded|CreateViaIdentity|CreateViaIdentityExpanded)([1-9]{1,2})$
    remove: true

#Remove cmdlet to avoid conflicts where alias has been set: [#3241](https://github.com/microsoftgraph/msgraph-sdk-powershell/issues/3241)
  - where:
      verb: Get
      subject: ^AllUserOnlineMeetingRecording$
    remove: true
  - where:
      verb: Get
      subject: ^AllUserOnlineMeetingTranscript$
    remove: true

```
