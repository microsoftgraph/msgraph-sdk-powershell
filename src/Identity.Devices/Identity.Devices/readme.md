<!-- region Generated -->
# Microsoft.Graph.Identity.Devices
This directory contains the PowerShell module for the IdentityDevices service.

---
## Status
[![Microsoft.Graph.Identity.Devices](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Identity.Devices.svg?style=flat-square&label=Microsoft.Graph.Identity.Devices "Microsoft.Graph.Identity.Devices")](https://www.powershellgallery.com/packages/Microsoft.Graph.Identity.Devices/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.Identity.Devices`, see [how-to.md](how-to.md).
<!-- endregion -->

### AutoRest Configuration

> see https://aka.ms/autorest

``` yaml
require:
  - $(this-folder)/../../readme.graph.md
  - $(this-folder)/../../../profiles/$(title)/readme.md
title: $(service-name)
subject-prefix: ''

directive:
# Rename cmdlets
  - where:
      verb: Get
      subject: (^Device$)
      variant: Get1|GetExpanded
    set:
      verb: Get
      subject: $1ById
```
### Versioning

``` yaml
module-version: 0.9.0
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
