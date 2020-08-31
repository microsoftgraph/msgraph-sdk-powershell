<!-- region Generated -->
# Microsoft.Graph.Identity.DirectorySettings
This directory contains the PowerShell module for the IdentityDirectorySettings service.

---
## Status
[![Microsoft.Graph.Identity.DirectorySettings](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Identity.DirectorySettings.svg?style=flat-square&label=Microsoft.Graph.Identity.DirectorySettings "Microsoft.Graph.Identity.DirectorySettings")](https://www.powershellgallery.com/packages/Microsoft.Graph.Identity.DirectorySettings/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.Identity.DirectorySettings`, see [how-to.md](how-to.md).
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
      subject: ^(Setting)(DirectorySetting)$
    set:
      subject: $2
```

### Versioning

``` yaml
module-version: 0.9.0
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
