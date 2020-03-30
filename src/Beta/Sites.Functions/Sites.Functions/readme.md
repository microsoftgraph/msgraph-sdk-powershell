<!-- region Generated -->
# Microsoft.Graph.Sites.Functions
This directory contains the PowerShell module for the SitesFunctions service.

---
## Status
[![Microsoft.Graph.Sites.Functions](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Sites.Functions.svg?style=flat-square&label=Microsoft.Graph.Sites.Functions "Microsoft.Graph.Sites.Functions")](https://www.powershellgallery.com/packages/Microsoft.Graph.Sites.Functions/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.Sites.Functions`, see [how-to.md](how-to.md).
<!-- endregion -->

### AutoRest Configuration

> see https://aka.ms/autorest

``` yaml
require:
  - $(this-folder)/../../../readme.graph.md
title: $(service-name)
subject-prefix: ''
input-file: $(spec-doc-repo)/$(title).yml
directive:
# Rename cmdlets
  - where:
      verb: Get
      subject: (^Site$)
    set:
      subject: $1ByPath
  - where:
      verb: Get
      subject: (^SiteActivity$)
    set:
      subject: $1ByInterval
  - where:
      verb: Get
      subject: (^SiteListItemActivity$|^SiteListItemActivityListItemActivity$|^SiteListActivityListItemActivity$)
    set:
      subject: SiteListItemActivityByInterval
  - where:
      verb: Get
      subject: ^SiteOnenoteNotebook(RecentNotebook$)
    set:
      subject: Get$1
  - where:
      verb: Invoke
      subject: ^PreviewSite(.*)
    set:
      subject: Preview$1
```

### Versioning

``` yaml
module-version: 0.2.1
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
