<!-- region Generated -->
# Microsoft.Graph.Devices.CloudPrint
This directory contains the PowerShell module for the DevicesCloudPrint service.

---
## Status
[![Microsoft.Graph.Devices.CloudPrint](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Devices.CloudPrint.svg?style=flat-square&label=Microsoft.Graph.Devices.CloudPrint "Microsoft.Graph.Devices.CloudPrint")](https://www.powershellgallery.com/packages/Microsoft.Graph.Devices.CloudPrint/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.Devices.CloudPrint`, see [how-to.md](how-to.md).
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
# Remove cmdlets
  - where:
      verb: New
      subject: PrintPrinter
      variant: Create|CreateExpanded
    remove: true
```
### Versioning

``` yaml
module-version: 1.3.0
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
