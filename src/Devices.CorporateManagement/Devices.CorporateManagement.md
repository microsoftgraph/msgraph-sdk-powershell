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
  - remove-path-by-operation: ^deviceAppManagement.wdacSupplementalPolicy.deviceStatus.*$|^deviceManagement.deviceHealthScript.deviceRunState.managedDevice_deleteUserFromSharedAppleDevice|^deviceAppManagement.mobileApp.userStatus.deviceStatus.app.microsoft.graph.iosVppApp_.*$|^deviceAppManagement.managedAppRegistration.(appliedPolicy|Intendedpolicy).microsoft.graph.*_.*$
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
# Alias DeviceAppManagement* cmdlets to DeviceAppMgt*.
  - where:
      subject: ^(DeviceAppManagement)(.*)
    set:
      subject: DeviceAppMgt$2
  - where:
      subject: ^DeviceAppMgt.*
    set:
      alias: ${verb}-${subject-prefix}${subject}
  - where:
      subject: ^(DeviceAppMgt)(.*)
    set:
      subject: DeviceAppManagement$2
```
