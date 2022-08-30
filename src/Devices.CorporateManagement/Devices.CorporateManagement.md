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

``` yaml
directive:
# Remove paths that are too long.
  - remove-path-by-operation: ^deviceAppManagement.wdacSupplementalPolicies.deviceStatuses.*$|^deviceManagement.deviceHealthScripts.deviceRunStates.managedDevice_deleteUserFromSharedAppleDevice|^deviceAppManagement.mobileApps.userStatuses.deviceStatuses.app.microsoft.graph.iosVppApp_.*$|^deviceAppManagement.managedAppRegistrations.(appliedPolicies|Intendedpolicies).microsoft.graph.*_.*$
# Rename cmdlets with duplicates in their name.
  - where:
      subject: ^(DeviceAppManagement)(\1)+
    set:
      subject: $1
# Rename cmdlets.
  - where:
      verb: Update
      subject: ^(DeviceAppManagement)(MobileAppRelationship)$
      variant: ^Update$|^UpdateExpanded$|^UpdateViaIdentity$|^UpdateViaIdentityExpanded$
    set:
      subject: $1Multiple$2
  # https://docs.microsoft.com/en-us/graph/api/resources/intune-devices-devicelogcollectionresponse?view=graph-rest-beta
  - where:
      subject: ^(UserManagedDeviceLogCollection)(Request)$
    set:
      subject: $1Response
  - where:
      verb: Update
      subject: ^(DeviceAppManagement)(PolicySet)$
      variant: ^Update1$|^UpdateExpanded1$|^UpdateViaIdentity1$|^UpdateViaIdentityExpanded1$
    set:
      subject: $1Multiple$2
```
