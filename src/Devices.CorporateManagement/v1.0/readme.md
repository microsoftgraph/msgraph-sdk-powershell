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
  - $(this-folder)/../Devices.CorporateManagement.md
title: $(service-name)
subject-prefix: ''
namespace: Microsoft.Graph.PowerShell
directive:
  - where:
      verb: Get
      subject: ^(DeviceAppManagementMobileAppAssignmentCount|DeviceAppManagementMobileAppCategoryCount)$
      variant: ^Get[1-17]$|^GetExpanded[1-17$|^GetViaIdentity[1-17]$|^GetViaIdentityExpanded[1-17]$
    remove: true
```
