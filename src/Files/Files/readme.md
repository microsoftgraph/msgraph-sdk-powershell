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
```
### Versioning

``` yaml
module-version: 1.3.0
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
