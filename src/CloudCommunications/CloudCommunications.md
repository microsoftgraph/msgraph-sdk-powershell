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

### Reviewed beta wrapper collision policy

The beta attendance-report and recording aliases retain every reviewed compatible
route. Attendance operations use the singleton defaults verified from the actual
Microsoft.Graph.Beta.CloudCommunications 2.38.0 public proxies and compiled route
dispatch, not the first URI in command metadata.

The reviewed beta recording GET policy intentionally differs from that published
SDK: both communication-bound and user-bound commands require an explicit
`-Route Binary` or `-Route Recordings`, with no `Published` choice or default
fallback. `Binary` selects the singleton `/recording` download. `Recordings`
selects `/recordings` or `/recordings/{callRecording-id}` according to the supplied
item ID. Each role validates its own required IDs and supported parameters before
calling Graph; neither role discards parameters or falls back to another route.

The published `Get2` default selects the collection-bound `getAllRecordings`
alias-argument function, not any of these three routes. The communication-bound
function remains unsupported by the current alias-argument generator, and the
user-bound function remains explicitly suppressed by shared directive 5 below.
Neither is restored to manufacture default compatibility. This policy is prepared
in the adjacent migration ledger; activation requires the canonical shared
dispatcher capability and its normal target-branch merge.

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
