<!-- region Generated -->
# Microsoft.Graph.Devices.CorporateManagement
This directory contains the PowerShell module for the DevicesCorporate service.

---
## Status
[![Microsoft.Graph.Devices.CorporateManagement](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Devices.CorporateManagement.svg?style=flat-square&label=Microsoft.Graph.Devices.CorporateManagement "Microsoft.Graph.Devices.CorporateManagement")](https://www.powershellgallery.com/packages/Microsoft.Graph.Devices.CorporateManagement/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.Devices.CorporateManagement`, see [how-to.md](how-to.md).
<!-- endregion -->

### AutoRest Configuration

> see https://aka.ms/autorest

``` yaml
require:
  - $(this-folder)/../../readme.graph.md
  - $(this-folder)/../../../profiles/$(title)/readme.md
title: $(service-name)
subject-prefix: ''
```

### Directives

> see https://github.com/Azure/autorest/blob/master/docs/powershell/directives.md

``` yaml
directive:
# Remove paths that are too long.
  - remove-path-by-operation: ^deviceAppManagement.wdacSupplementalPolicies.deviceStatuses(.policy_assign|_GetPolicy|_GetRefPolicy|_UpdateRefPolicy|_DeleteRefPolicy|_SetRefPolicy)$|^deviceManagement.deviceHealthScripts.deviceRunStates.managedDevice_deleteUserFromSharedAppleDevice$
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
      subject: Io(Lob|Managed)
    set:
      subject: iOS$1
# Rename DeviceAppManagement* cmdlets to DeviceAppMgt*. Alias DeviceAppMgt* to DeviceAppManagement*.
# This should always be the last directive.
  - where:
      subject: ^DeviceAppManagement.*
    set:
      alias: ${verb}-Mg${subject}
  - where:
      subject: (.*)(DeviceAppManagement)(.*)
    set:
      subject: $1DeviceAppMgt$3
# Rename cmdlets.
  - where:
      subject: ^(Office)(Configuration)(ClientConfiguration.*)
    set:
      subject: $1$3
```
### Versioning

``` yaml
module-version: 1.3.0
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
