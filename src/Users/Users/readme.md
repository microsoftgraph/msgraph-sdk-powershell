<!-- region Generated -->
# Microsoft.Graph.Users
This directory contains the PowerShell module for the Users service.

---
## Status
[![Microsoft.Graph.Users](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Users.svg?style=flat-square&label=Microsoft.Graph.Users "Microsoft.Graph.Users")](https://www.powershellgallery.com/packages/Microsoft.Graph.Users/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.Users`, see [how-to.md](how-to.md).
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
# Remove invalid root paths e.g. users{id}/todo
  - remove-path-by-operation: users_(Get|Create|Update|Delete|Set)(Todo|outlook)
```
### Versioning

``` yaml
module-version: 1.3.0
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
