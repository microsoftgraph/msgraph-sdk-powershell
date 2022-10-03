<!-- region Generated -->
# Microsoft.Graph.ManagedTenants
This directory contains the PowerShell module for the ManagedTenants service.

---
## Status
[![Microsoft.Graph.ManagedTenants](https://img.shields.io/powershellgallery/v/Microsoft.Graph.ManagedTenants.svg?style=flat-square&label=Microsoft.Graph.ManagedTenants "Microsoft.Graph.ManagedTenants")](https://www.powershellgallery.com/packages/Microsoft.Graph.ManagedTenants/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.ManagedTenants`, see [how-to.md](how-to.md).
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
  - remove-path-by-operation: ^tenantRelationships_.*ManagedTenants$
```
### Versioning

``` yaml
module-version: 1.12.3
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
