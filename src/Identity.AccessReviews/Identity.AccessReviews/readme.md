<!-- region Generated -->
# Microsoft.Graph.Identity.AccessReviews
This directory contains the PowerShell module for the IdentityAccessReviews service.

---
## Status
[![Microsoft.Graph.Identity.AccessReviews](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Identity.AccessReviews.svg?style=flat-square&label=Microsoft.Graph.Identity.AccessReviews "Microsoft.Graph.Identity.AccessReviews")](https://www.powershellgallery.com/packages/Microsoft.Graph.Identity.AccessReviews/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.Identity.AccessReviews`, see [how-to.md](how-to.md).
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
# Rename cmdlets with duplicates in their name.
  - where:
      subject: ^(BusinessFlowTemplate)(\1)+
    set:
      subject: $1
  - where:
      subject: ^(ProgramControlType)(\1)+
    set:
      subject: $1
```
### Versioning

``` yaml
module-version: 0.9.2
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
