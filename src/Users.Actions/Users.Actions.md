# Users.Actions

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for Users.Actions v1.0 and/or beta modules.

## AutoRest Configuration

> see <https://aka.ms/autorest>

``` yaml
require:
  - $(this-folder)/../readme.graph.md
```

### Directives

> see https://github.com/Azure/autorest/blob/master/docs/powershell/directives.md

The reviewed v3 migration covers this shared file only. All profile-local readmes
(including their Users.Actions directive groups) and `src/readme.graph.md` are
explicitly ignored. Neither API profile is excluded. Parameter/schema aliases and
transforms remain deferred, not implemented by this cmdlet-surface migration.
`wrapper/Users.Actions_directiveMigrationMap.json` records all 16 dispositions and
the complete actual legacy-to-compatible operation audit. An empty selection means
no matching operation in this module's same-profile specs, not removal from Graph.
The active AutoRest directives below are retained for the legacy pipeline.

``` yaml
directive:
# Remove invalid paths.
# Wrapper migration 1: original regex matches zero of the actual 20 v1.0 / 30 beta
# legacy operations. Full metadata-guarded path bridges are audited in the ledger;
# current compatible IDs are aligned; all 20 v1.0 / 33 beta IDs also match zero.
# Three compatible-only beta actions are audited separately. No suppression added.
  - remove-path-by-operation: .*exceptionOccurrence.*|user\.joinedTeam.*|user\.onenote\..*.parent.*|user.*\.calendarView.*|.*\.notebook\.section.*|.*\.sectionGroup\.section.*|.*\.section\.page.*|user\.calendar\.event.*|user\.calendarGroup\.calendar.*|user\.calendar\.event.*|user\.event\.calendar\.event.*|user\.pendingAccessReviewInstance\.stage\.decision.*|user\.pendingAccessReviewInstance(\.decision|\.stage\.decision)\.instance.*
# Rename All due to https://github.com/Azure/autorest.powershell/issues/1002.
# Wrapper migration 2: exact POST removeAllDevicesFromManagement fallback preserves
# Remove-AllUserDeviceFromManagement in beta; authoritative v1.0 derived name stays.
  - where:
      verb: Remove
      subject: ^(UserDeviceFromManagement)$
    set:
      subject: All$1
# Wrapper migration 3: exact beta POST invalidateAllRefreshTokens noun override.
# The corresponding action is absent from both actual v1.0 module specs.
  - where:
      verb: Invoke
      subject: ^(Invalidate)(UserRefreshToken)$
    set:
      subject: $1All$2
# Remove cmdlets.
# Wrapper migration 4: exact beta POST getUserOwnedObjects verb/noun overrides
# preserve Get-UserOwnedObjectByType; no corresponding v1.0 module operation.
  - where:
      verb: Get
      subject: ^(UserOwnedObject)$
    set:
      subject: $1ByType
# Wrapper migration 5: no matching onlineMeeting operation in either actual module
# spec; no speculative suppression of routes owned by another module.
  - where:
      verb: Get
      subject: ^(UserOnlineMeeting)$
    remove: true
# Wrapper migration 6: no matching createOrGet operation in either actual module
# spec. Profile-local directives remain ignored, not copied into wrapper config.
  - where:
      verb: New
      subject: ^(UserOnlineMeeting)$
    set:
      verb: Invoke
      subject: CreateOrGet$1
# Wrapper migration 7: no matching onenote page content route in either module spec.
  - where:
      verb: Update
      subject: ^(UserOnenotePage)$
    set:
      subject: $1Content
# Wrapper migration 8: exact POST changePassword verb/noun fallback preserves
# Update-UserPassword in beta while retaining the existing v1.0 derived result.
  - where:
      verb: Rename
      subject: ^(UserPassword)$
    set:
      verb: Update
      subject: $1
# Wrapper migration 9: no getSchedule operation in either actual module spec.
# The numbered legacy variants are not guessed from unrelated calendar routes.
  - where:
      verb: Get
      subject: ^(User)(CalendarSchedule)$
      variant: ^Get$|^GetExpanded$|^GetViaIdentity$|^GetViaIdentityExpanded$
    set:
      subject: $1Default$2
# Wrapper migration 10: no message reply/replyAll operation in either module spec.
  - where:
      verb: Invoke
      subject: ^(Reply)(UserMessage|UserMailFolderMessage|UserMailFolderChildFolderMessage)$
      variant: ^Reply1$|^ReplyExpanded1$|^ReplyViaIdentity1$|^ReplyViaIdentityExpanded1$
    set:
      subject: $1All$2
# Wrapper migration 11: no createReply/createReplyAll operation in either module spec.
  - where:
      verb: New
      subject: ^(User)(Message|MailFolderMessage|MailFolderChildFolderMessage)(Reply)$
      variant: ^Create1$|^CreateExpanded1$|^CreateViaIdentity1$|^CreateViaIdentityExpanded1$
    set:
      subject: $1$2$3All
  # https://docs.microsoft.com/en-us/graph/api/resources/intune-devices-devicelogcollectionresponse?view=graph-rest-beta
# Wrapper migration 12: no managed-device log download action in either module spec.
  - where:
      verb: New
      subject: ^(UserManagedDeviceLogCollection)Request(DownloadUrl)$
    set:
      subject: $1Response$2
# Wrapper migration 13: no windowsDefenderUpdateSignatures action in either module spec.
  - where:
      verb: Update
      subject: ^(UserManagedDevice)$
    set:
      verb: New
      subject: $1WindowsDefenderUpdateSignature
# Wrapper migration 14: no bulkRestoreCloudPc action in either actual module spec.
  - where:
      verb: Invoke
      subject: ^Bulk(UserManagedDevice)RestoreCloudPc$
    set:
      subject: BulkRestore$1CloudPc
# Wrapper migration 15: no bulkReprovisionCloudPc action in either actual module spec.
  - where:
      verb: Invoke
      subject: ^Bulk(UserManagedDevice)ReprovisionCloudPc$
    set:
      subject: BulkReprovision$1CloudPc
# Wrapper migration 16: no reprovisionCloudPc action in either actual module spec.
  - where:
      verb: Invoke
      subject: ^Cloud(UserManagedDevice)$
    set:
      subject: Reprovision$1CloudPc
```
