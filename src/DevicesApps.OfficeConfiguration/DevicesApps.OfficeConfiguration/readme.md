<!-- region Generated -->
# Microsoft.Graph.DevicesApps.OfficeConfiguration
This directory contains the PowerShell module for the DevicesAppsOfficeConfiguration service.

---
## Status
[![Microsoft.Graph.DevicesApps.OfficeConfiguration](https://img.shields.io/powershellgallery/v/Microsoft.Graph.DevicesApps.OfficeConfiguration.svg?style=flat-square&label=Microsoft.Graph.DevicesApps.OfficeConfiguration "Microsoft.Graph.DevicesApps.OfficeConfiguration")](https://www.powershellgallery.com/packages/Microsoft.Graph.DevicesApps.OfficeConfiguration/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.DevicesApps.OfficeConfiguration`, see [how-to.md](how-to.md).
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
# Rename cmdlets.
  - where:
      subject: ^(Office)(Configuration)(ClientConfiguration.*)
    set:
      subject: $1$3
```

### Versioning

``` yaml
module-version: 0.9.0
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
