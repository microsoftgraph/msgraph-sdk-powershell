<!-- region Generated -->
# Microsoft.Graph.DevicesApps.DeviceAppManagement
This directory contains the PowerShell module for the DevicesAppsDeviceApp service.

---
## Status
[![Microsoft.Graph.DevicesApps.DeviceAppManagement](https://img.shields.io/powershellgallery/v/Microsoft.Graph.DevicesApps.DeviceAppManagement.svg?style=flat-square&label=Microsoft.Graph.DevicesApps.DeviceAppManagement "Microsoft.Graph.DevicesApps.DeviceAppManagement")](https://www.powershellgallery.com/packages/Microsoft.Graph.DevicesApps.DeviceAppManagement/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.DevicesApps.DeviceAppManagement`, see [how-to.md](how-to.md).
<!-- endregion -->

### AutoRest Configuration

> see https://aka.ms/autorest

``` yaml
require:
  - $(this-folder)/../../../readme.graph.md
title: $(service-name)
subject-prefix: ''
input-file: $(spec-doc-repo)/$(title).yml
directive:
# Remove paths that are too long.
  - remove-path-by-operation: ^deviceAppManagement.wdacSupplementalPolicies.deviceStatuses.policy_assign$
  - where:
      verb: Update
      subject: ^(DeviceAppManagementMobileAppRelationship)$
      variant: ^Update$|^UpdateExpanded$|^UpdateViaIdentity$|^UpdateViaIdentityExpanded$
    set:
      subject: Multiple$1
  - where:
      verb: Update
      subject: ^(DeviceAppManagementPolicySet)$
      variant: ^Update1$|^UpdateExpanded1$|^UpdateViaIdentity1$|^UpdateViaIdentityExpanded1$
    set:
      subject: Multiple$1
```

### Versioning

``` yaml
module-version: 0.2.1
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
