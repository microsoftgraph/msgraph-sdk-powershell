# Devices.CorporateManagement

This directory contains common [AutoREST.PowerShell](https://github.com/Azure/autorest.powershell) configurations for Devices.CorporateManagement v1.0 and/or beta modules.

## AutoRest Configuration

> see <https://aka.ms/autorest>

``` yaml
require:
  - $(this-folder)/../readme.graph.md
```

### Directives

> see https://github.com/Azure/autorest/blob/master/docs/powershell/directives.md

The wrapper keeps the shared directives below active and records the reviewed
dispositions in `wrapper/Devices.CorporateManagement_directiveMigrationMap.json`.
Its eBook category GET variants use the existing mandatory `ManagedEBookId`, with
the root list/count as defaults. The app-scoped navigation described as "direct
relationships for this app" uses `DirectRelationship` for colliding GET, POST and
DELETE commands; the existing noncolliding PATCH names are unchanged. This
preserves endpoints without applying any profile-local removal directive or
introducing a public route selector.

``` yaml
directive:
# Wrapper migration: the adjacent wrapper/Devices.CorporateManagement_directiveMigrationMap.json
# records exact v1.0/beta evidence. DevicesCorporateManagementDirectiveMigrationTests
# pins reviewed naming and unaffected neighbors. Keep all AutoRest directives active.
# Remove paths that are too long.
# Wrapper migration: actual legacy IDs select zero v1.0 operations and two beta GETs.
# Complete source/current method/path evidence suppresses nested deviceStatuses/{id}/policy
# and deviceStatuses/$count under wdacSupplementalPolicies, not the status collection/items.
  - remove-path-by-operation: ^deviceAppManagement.wdacSupplementalPolicy.deviceStatus.*$|^deviceManagement.deviceHealthScript.deviceRunState.managedDevice_deleteUserFromSharedAppleDevice|^deviceAppManagement.mobileApp.userStatus.deviceStatus.app.microsoft.graph.iosVppApp_.*$|^deviceAppManagement.managedAppRegistration.(appliedPolicy|Intendedpolicy).microsoft.graph.*_.*$
# Rename cmdlets with duplicates in their name.
# Wrapper migration: structural naming emits the singleton root once; exact
# beta deviceAppManagementTasks overrides collapse the repeated multiword prefix.
  - where:
      subject: ^(DeviceAppManagement)(\1)+
    set:
      subject: $1
# Rename cmdlets.
# Wrapper migration: exact PATCH relationship fallback; v1.0 derived coverage is retained.
  - where:
      verb: Update
      subject: ^(DeviceAppManagement)(MobileAppRelationship)$
      variant: ^Update$|^UpdateExpanded$|^UpdateViaIdentity$|^UpdateViaIdentityExpanded$
    set:
      subject: $1Multiple$2
  # https://docs.microsoft.com/en-us/graph/api/resources/intune-devices-devicelogcollectionresponse?view=graph-rest-beta
# Wrapper migration: exact collection/item Response fallback, not the count or actions.
  - where:
      subject: ^(UserManagedDeviceLogCollection)(Request)$
    set:
      subject: $1Response
# Wrapper migration: Update1 is POST policySets/{id}/update in beta, not item PATCH.
# The module configuration preserves both its Multiple noun and Update verb.
  - where:
      verb: Update
      subject: ^(DeviceAppManagement)(PolicySet)$
      variant: ^Update1$|^UpdateExpanded1$|^UpdateViaIdentity1$|^UpdateViaIdentityExpanded1$
    set:
      subject: $1Multiple$2
# Deferred parameter migration: retain both Count/Count1 -> ItemCount groups unchanged.
  - where:
      verb: Get
      subject: ^DeviceAppManagementMobileAppTopMobileApp$
      variant: GetViaIdentity
      parameter-name: Count
    set:
      parameter-name: ItemCount
  - where:
      verb: Get
      subject: ^DeviceAppManagementMobileAppTopMobileApp$
      variant: ^Get$
      parameter-name: Count1
    set:
      parameter-name: ItemCount
# Wrapper migration: exact iOS route tables cover both profiles; existing v1.0
# derived names remain authoritative where available.
  - where:
      subject: Io(Lob|Managed)
    set:
      subject: iOS$1
# Alias DeviceAppManagement* cmdlets to DeviceAppMgt*.
# Reviewed alias scaffolding: these subject changes are a round trip, not a final
# DeviceAppMgt rename. Structural naming retains DeviceAppManagement. Alias emission
# itself (the middle group) is explicitly deferred with the parameter/alias work.
  - where:
      subject: ^(DeviceAppManagement)(.*)
    set:
      subject: DeviceAppMgt$2
  - where:
      subject: ^DeviceAppMgt.*
    set:
      alias: ${verb}-Mg${subject-prefix}${subject}
  - where:
      subject: ^(DeviceAppMgt)(.*)
    set:
      subject: DeviceAppManagement$2
# End alias
# Wrapper migration: operation-based generation has one collection POST for logCollectionRequests.
# It does not emit AutoRest numbered duplicate Create variants; retain the real New operation.
  - where:
      verb: New
      subject: ^UserManagedDeviceLogCollectionResponse$
      variant: ^(Create|CreateExpanded|CreateViaIdentity|CreateViaIdentityExpanded)([1-9]{1,2})$
    remove: true
```
