<!-- region Generated -->
# Microsoft.Graph.Sites.Site
This directory contains the PowerShell module for the SitesSite service.

---
## Status
[![Microsoft.Graph.Sites.Site](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Sites.Site.svg?style=flat-square&label=Microsoft.Graph.Sites.Site "Microsoft.Graph.Sites.Site")](https://www.powershellgallery.com/packages/Microsoft.Graph.Sites.Site/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.Sites.Site`, see [how-to.md](how-to.md).
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
  - where:
      verb: Remove
      subject: Site
      variant: Remove
    hide: true
  - where:
      verb: Remove
      subject: Site
      variant: RemoveExpanded
    hide: true
  - where:
      verb: Get
      subject: Site
      variant: Get1
    set:
      subject: SubSite
  - where:
      verb: Get
      subject: Site
      variant: List1
    set:
      subject: SubSite
  - where:
      verb: Get
      subject: Site
      variant: GetViaIdentity1
    set:
      subject: SubSite
  - where:
      verb: New
      subject: Site
      variant: Create1
    set:
      subject: SubSite
  - where:
      verb: New
      subject: Site
      variant: CreateExpanded1
    set:
      subject: SubSite
  - where:
      verb: New
      subject: Site
      variant: CreateViaIdentity
    set:
      subject: SubSite
  - where:
      verb: New
      subject: Site
      variant: CreateViaIdentityExpanded
    set:
      subject: SubSite
```
### Versioning

``` yaml
module-version: 0.5.1
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
