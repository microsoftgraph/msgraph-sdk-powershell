<!-- region Generated -->
# Microsoft.Graph.Files
This directory contains the PowerShell module for the Files service.

---
## Status
[![Microsoft.Graph.Files](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Files.svg?style=flat-square&label=Microsoft.Graph.Files "Microsoft.Graph.Files")](https://www.powershellgallery.com/packages/Microsoft.Graph.Files/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.Files`, see [how-to.md](how-to.md).
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
  - remove-path-by-operation: .*_(Create|Get|Update|Set|Delete)Activities$|.*\.activities.*$|shares\..*_createLink
# Rename cmdlets
  - where:
      verb: Get
      subject: ^(Group|User)(Drive)$
      variant: ^Get$|^GetViaIdentity$|^Get2$|^GetViaIdentity2$
    set:
      subject: $1Default$2
```
### Versioning

``` yaml
module-version: 1.10.1
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
