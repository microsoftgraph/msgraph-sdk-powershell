<!-- region Generated -->
# Microsoft.Graph.Compliance
This directory contains the PowerShell module for the Compliance service.

---
## Status
[![Microsoft.Graph.Compliance](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Compliance.svg?style=flat-square&label=Microsoft.Graph.Compliance "Microsoft.Graph.Compliance")](https://www.powershellgallery.com/packages/Microsoft.Graph.Compliance/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.Compliance`, see [how-to.md](how-to.md).
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
# Remove undocumented cmdlets
  - where:
      subject: (^ComplianceEdiscoveryCaseNoncustodialDataSource$)
      variant: ^Get1$|^GetViaIdentity1$|^Update1$|^UpdateExpanded1$|^UpdateViaIdentity1$|^UpdateViaIdentityExpanded1$|^Delete1$|^DeleteViaIdentity1$
    remove: true
```
### Versioning

``` yaml
module-version: 1.5.0
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
