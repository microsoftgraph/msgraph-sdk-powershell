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

### Reviewed wrapper collision naming

The singleton `meetingAttendanceReport` describes the attendance report of the
**latest online meeting session**. Its commands use the distinct
`OnlineMeetingLatestAttendanceReport` noun, including their attendance-record
navigation and count commands. The `attendanceReports` collection and its
ID-selected reports keep their existing `OnlineMeetingAttendanceReport` names.
This avoids ambiguous parameter sets with the same mandatory meeting IDs.

The singleton `/recording` describes the **content stream of a Teams live-event
recording**, not the JSON `callRecording` entities in `/recordings`. Its commands
use `OnlineMeetingLiveEventRecording`; the plural recording list/item and their
`/content` endpoints keep their existing names. Both communication-bound and
user-bound routes remain available. No route selector, broad suppression, response
union, or authored profile filter is introduced. Ordinary list/item dispatchers
retain their existing `List` default.

The published `Get2` default selects the collection-bound `getAllRecordings`
alias-argument function, not any of these three routes. The communication-bound
function remains unsupported by the current alias-argument generator, and the
user-bound function remains explicitly suppressed by shared directive 5 below.
Neither is restored to manufacture default compatibility. These meaningful names
intentionally differ from the published 2.38.0 combined command/default surface;
the adjacent ledger records the exact source descriptions and affected operations.
The rules are shared: both compatible profiles are checked, and paths absent from
v1.0 do not require a separate profile-only configuration.
The existing emitter still skips the two binary `/recording` PUT operations with
bodyless success responses. Their typed client routes remain generated; this
migration neither suppresses them nor claims new upload-cmdlet support.

``` yaml
directive:
# Remove invalid paths.
# Wrapper migration: all 13 actual legacy operation-ID matches in each profile
# survive with aligned compatible IDs. Tests pin complete original/current sets;
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
