<!-- region Generated -->
# Microsoft.Graph.Devices.ServiceAnnouncement
This directory contains the PowerShell module for the DevicesServiceAnnouncement service.

---
## Status
[![Microsoft.Graph.Devices.ServiceAnnouncement](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Devices.ServiceAnnouncement.svg?style=flat-square&label=Microsoft.Graph.Devices.ServiceAnnouncement "Microsoft.Graph.Devices.ServiceAnnouncement")](https://www.powershellgallery.com/packages/Microsoft.Graph.Devices.ServiceAnnouncement/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.Devices.ServiceAnnouncement`, see [how-to.md](how-to.md).
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
# Remove invalid paths.
  - remove-path-by-operation: ^admin(?!\.serviceAnnouncement).*$

# Drop admin from command names.
  - where:
      subject: (.*)AdminServiceAnnouncement(.*)
    set:
      subject: $1ServiceAnnouncement$2
```
### Versioning

``` yaml
module-version: 1.9.4
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
