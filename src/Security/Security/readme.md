<!-- region Generated -->
# Microsoft.Graph.Security
This directory contains the PowerShell module for the Security service.

---
## Status
[![Microsoft.Graph.Security](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Security.svg?style=flat-square&label=Microsoft.Graph.Security "Microsoft.Graph.Security")](https://www.powershellgallery.com/packages/Microsoft.Graph.Security/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.Security`, see [how-to.md](how-to.md).
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
      verb: Get|Update
      subject: ^Security$
    remove: true
# Rename cmdlets
  - where:
      verb: Remove
      subject: ^(SecurityTiIndicator)$
      variant: Delete2|DeleteExpanded1
    set:
      subject: $1ByExternalId
  - where:
      verb: Remove
      subject: ^(SecurityTiIndicator)$
      variant: Delete1|DeleteExpanded
    set:
      subject: $1Multiple
  - where:
      verb: Update
      subject: ^(SecurityAlert)$
      variant: Update1|UpdateExpanded1
    set:
      subject: $1Multiple
  - where:
      verb: Update
      subject: ^(SecurityTiIndicator)$
      variant: Update1|UpdateExpanded1
    set:
      subject: $1Multiple
```
### Versioning

``` yaml
module-version: 1.3.0
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
