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

``` yaml
directive:
# Remove invalid paths.
  - remove-path-by-operation: .*exceptionOccurrence.*|user\.joinedTeam.*|user\.onenote\..*.parent.*|user.*\.calendarView.*|.*\.notebook\.section.*|.*\.sectionGroup\.section.*|.*\.section\.page.*|user\.calendar\.event.*|user\.calendarGroup\.calendar.*|user\.calendar\.event.*|user\.event\.calendar\.event.*|user\.pendingAccessReviewInstance\.stage\.decision.*|user\.pendingAccessReviewInstance(\.decision|\.stage\.decision)\.instance.*
# Rename All due to https://github.com/Azure/autorest.powershell/issues/1002.
  - where:
      verb: Remove
      subject: ^(UserDeviceFromManagement)$
    set:
      subject: All$1
  - where:
      verb: Invoke
      subject: ^(Invalidate)(UserRefreshToken)$
    set:
      subject: $1All$2
# Remove cmdlets.
  - where:
      verb: Get
      subject: ^(UserOwnedObject)$
    set:
      subject: $1ByType
  - where:
      verb: Get
      subject: ^(UserOnlineMeeting)$
    remove: true
  - where:
      verb: New
      subject: ^(UserOnlineMeeting)$
    set:
      verb: Invoke
      subject: CreateOrGet$1
  - where:
      verb: Update
      subject: ^(UserOnenotePage)$
    set:
      subject: $1Content
  - where:
      verb: Rename
      subject: ^(UserPassword)$
    set:
      verb: Update
      subject: $1
  - where:
      verb: Get
      subject: ^(User)(CalendarSchedule)$
      variant: ^Get$|^GetExpanded$|^GetViaIdentity$|^GetViaIdentityExpanded$
    set:
      subject: $1Default$2
  - where:
      verb: Invoke
      subject: ^(Reply)(UserMessage|UserMailFolderMessage|UserMailFolderChildFolderMessage)$
      variant: ^Reply1$|^ReplyExpanded1$|^ReplyViaIdentity1$|^ReplyViaIdentityExpanded1$
    set:
      subject: $1All$2
  - where:
      verb: New
      subject: ^(User)(Message|MailFolderMessage|MailFolderChildFolderMessage)(Reply)$
      variant: ^Create1$|^CreateExpanded1$|^CreateViaIdentity1$|^CreateViaIdentityExpanded1$
    set:
      subject: $1$2$3All
  # https://docs.microsoft.com/en-us/graph/api/resources/intune-devices-devicelogcollectionresponse?view=graph-rest-beta
  - where:
      verb: New
      subject: ^(UserManagedDeviceLogCollection)Request(DownloadUrl)$
    set:
      subject: $1Response$2
  - where:
      verb: Update
      subject: ^(UserManagedDevice)$
    set:
      verb: New
      subject: $1WindowsDefenderUpdateSignature
  - where:
      verb: Invoke
      subject: ^Bulk(UserManagedDevice)RestoreCloudPc$
    set:
      subject: BulkRestore$1CloudPc
  - where:
      verb: Invoke
      subject: ^Bulk(UserManagedDevice)ReprovisionCloudPc$
    set:
      subject: BulkReprovision$1CloudPc
  - where:
      verb: Invoke
      subject: ^Cloud(UserManagedDevice)$
    set:
      subject: Reprovision$1CloudPc
```
