<!-- region Generated -->
# Microsoft.Graph.Sites.Actions
This directory contains the PowerShell module for the SitesActions service.

---
## Status
[![Microsoft.Graph.Sites.Actions](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Sites.Actions.svg?style=flat-square&label=Microsoft.Graph.Sites.Actions "Microsoft.Graph.Sites.Actions")](https://www.powershellgallery.com/packages/Microsoft.Graph.Sites.Actions/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.Sites.Actions`, see [how-to.md](how-to.md).
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
  - remove-path-by-operation: .*.onenote..*.parent.*|.*.notebooks.section.*|.*.sectionGroups.section.*|.*.sections.pages.*
# Remove Add|Remove-MgSite. They are duplicate of Sites.Site.
  - where:
      subject: (^Site$)
    remove: true
# Rename cmdlets that call onenotePatchContent action.
  - where:
      verb: Update
      subject: (^SiteOnenote.*)
    set:
      subject: $1Content
```

### Versioning

``` yaml
module-version: 0.9.0
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
