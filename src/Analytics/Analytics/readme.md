<!-- region Generated -->
# Microsoft.Graph.Analytics
This directory contains the PowerShell module for the Analytics service.

---
## Status
[![Microsoft.Graph.Analytics](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Analytics.svg?style=flat-square&label=Microsoft.Graph.Analytics "Microsoft.Graph.Analytics")](https://www.powershellgallery.com/packages/Microsoft.Graph.Analytics/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.Analytics`, see [how-to.md](how-to.md).
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
# Remove paths that are not valid.
  - remove-path-by-operation: ^users_(Get|Create|Update|Delete)Analytics$|^users.analytics_(Create|Update|Delete)ActivityStatistics$|^users_.*Insights$|^users.insights_(Create|Update|Delete)(Shared|Trending|Used)$
# Rename
  - where:
      subject: ^(User)Analytic(ActivityStatistics)$
    set:
      subject: $1$2
  - where:
      subject: ^(User)(Insight)(.*)$
    set:
      subject: $1$3$2
  - where:
      subject: ^(User)(Shared)(LastSharedMethodInsight)$
    set:
      subject: $1$3
```

### Versioning

``` yaml
module-version: 0.9.0
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
