<!-- region Generated -->
# Microsoft.Graph.Beta.Devices.CorporateManagement
This directory contains the PowerShell module for the DevicesCorporate service.

---
## Status
[![Microsoft.Graph.Beta.Devices.CorporateManagement](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Beta.Devices.CorporateManagement.svg?style=flat-square&label=Microsoft.Graph.Beta.Devices.CorporateManagement "Microsoft.Graph.Beta.Devices.CorporateManagement")](https://www.powershellgallery.com/packages/Microsoft.Graph.Beta.Devices.CorporateManagement/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.Beta.Devices.CorporateManagement`, see [how-to.md](how-to.md).
<!-- endregion -->

### AutoRest Configuration

> see https://aka.ms/autorest

``` yaml
require:
  - $(this-folder)/../Devices.CorporateManagement.md
title: $(service-name)
subject-prefix: 'Beta'
namespace: Microsoft.Graph.Beta.PowerShell
directive:
  - where:
      verb: Get
      subject: ^(DeviceAppManagementMobileAppAssignmentCount|DeviceAppManagementMobileAppCategoryCount|DeviceAppManagementMobileAppContentVersionFileCount|DeviceAppManagementMobileAppContentVersionCount|DeviceAppManagementMobileAppContentVersionContainedAppCount|DeviceAppManagementMobileAppRelationshipCount)$
      variant: ^(Get|GetExpanded|GetViaIdentity|GetViaIdentityExpanded)([1-9]{1,2})$
    remove: true
  # These cmdlet is causing build pipeline errors due multiple parameter types in the body parameter
  - where:
      verb: Update
      subject: ^DeviceAppManagementMobileAppRelationship$
    remove: true
```
