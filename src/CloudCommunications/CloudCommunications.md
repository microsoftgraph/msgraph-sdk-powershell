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

The shared cmdlet directives below are reviewed in
`wrapper/CloudCommunications_directiveMigrationMap.json` and covered by
`CloudCommunicationsDirectiveMigrationTests`. Profile-local directives (including
virtual-appointment SMS variants) and `src/readme.graph.md` are excluded. This file
contains no parameter or schema/response directives to defer. Keep the AutoRest
directives active until the service-module pipeline is retired.

``` yaml
directive:
# Remove invalid paths.
# Wrapper migration: 13 actual legacy operation-ID matches in each profile bridge
# uniquely to compatible operations. The ledger retains both old and current IDs;
# exact method/path suppressions preserve neighboring call and callRecord routes.
  - remove-path-by-operation: ^communication(.cloudCommunication_.*CloudCommunication|_(List|Create|Update|Delete)CallRecord|.callRecord.session_.*Segment|(_List|_Update)Call)$
# Rename cmdlets
# Wrapper migration: rename only beta POST .../participants/muteAll. The v1.0
# compatible spec has no collection-bound muteAll; individual mute stays unchanged.
  - where:
      verb: Invoke
      subject: ^Mute(CommunicationCallParticipant)$
      variant: ^Mute1$|^MuteExpanded1$|^MuteViaIdentity1$|^MuteViaIdentityExpanded1$
    set:
      subject: MuteAll$1
# Wrapper migration: POST /communications/onlineMeetings/createOrGet gets the
# curated CreateOrGetCommunicationOnlineMeeting noun; action metadata supplies
# Invoke structurally. Existing v1.0 derived coverage agrees with this rename.
  - where:
      verb: New
      subject: ^(CommunicationOnlineMeeting)$
      variant: ^Create1$|^CreateExpanded1$
    set:
      verb: Invoke
      subject: CreateOrGet$1
# Wrapper migration: suppress user-bound createOrGet in both profiles, not the
# ordinary POST /users/{user-id}/onlineMeetings. Existing v1.0 derived coverage agrees.
  - where:
      verb: New
      subject: ^UserOnlineMeeting$
      variant: ^(Create|CreateExpanded|CreateViaIdentity|CreateViaIdentityExpanded)([1-9]{1,2})$
    remove: true

#Remove cmdlet to avoid conflicts where alias has been set: [#3241](https://github.com/microsoftgraph/msgraph-sdk-powershell/issues/3241)
# Wrapper migration: suppress only the user-bound getAllRecordings/getAllTranscripts
# functions in both profiles. Communication-bound functions and meeting-level
# recordings/transcripts navigation operations remain available.
  - where:
      verb: Get
      subject: ^AllUserOnlineMeetingRecording$
    remove: true
  - where:
      verb: Get
      subject: ^AllUserOnlineMeetingTranscript$
    remove: true

```
