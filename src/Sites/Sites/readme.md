<!-- region Generated -->
# Microsoft.Graph.Sites
This directory contains the PowerShell module for the Sites service.

---
## Status
[![Microsoft.Graph.Sites](https://img.shields.io/powershellgallery/v/Microsoft.Graph.Sites.svg?style=flat-square&label=Microsoft.Graph.Sites "Microsoft.Graph.Sites")](https://www.powershellgallery.com/packages/Microsoft.Graph.Sites/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Development
For information on how to develop for `Microsoft.Graph.Sites`, see [how-to.md](how-to.md).
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
# Remove invalid paths.
  - remove-path-by-operation: .*\.onenote\..*\.parent.*|.*\.notebooks\.section.*|.*\.sectionGroups\.section.*|.*\.sections\.pages.*|sites\..*_(Create|Get|Update|Delete)Activities$|sites\..*\.activities.*|^sites_(remove|add)$
# Remove cmdlets
  - where:
      verb: Remove
      subject: ^Site$
    hide: true
# Rename cmdlets
  - where:
      verb: Get
      subject: ^Site$
      variant: ^Get$|^GetViaIdentity$|^List$|^Get3$|^GetViaIdentity3$|^List2$
    set:
      subject: SubSite
  - where:
      verb: Update
      subject: ^Site$
      variant: ^Update$|^UpdateExpanded$|^UpdateViaIdentity$|^UpdateViaIdentityExpanded$|^Update2$|^UpdateExpanded2$|^UpdateViaIdentity2$|^UpdateViaIdentityExpanded2$
    set:
      subject: SubSite
  - where:
      verb: New
      subject: ^Site$
      variant: ^Create$|^CreateExpanded$|^CreateViaIdentity$|^CreateViaIdentityExpanded$|^Create2$|^CreateExpanded2$|^CreateViaIdentity1$|^CreateViaIdentityExpanded1$
    set:
      subject: SubSite
  - where:
      verb: Get
      subject: (^Site$)
      variant: ^Get2$|^GetViaIdentity2$|^Get5$|^GetViaIdentity5$
    set:
      subject: $1ByPath
  - where:
      verb: Get
      subject: (^SiteActivity$)
    set:
      subject: $1ByInterval
  - where:
      verb: Get
      subject: (^SiteListItemActivity$)
    set:
      subject: $1ByInterval
  - where:
      verb: Get
      subject: ^(Site)OnenoteNotebook(RecentNotebook$)
    set:
      subject: $1$2
# Rename cmdlets that call onenotePatchContent action.
  - where:
      verb: Update
      subject: (^SiteOnenote.*)
    set:
      subject: $1Content
  - where:
      parameter-name: SiteId
      verb: Get
      subject: (SiteAnalytic|SiteColumn|SiteContentType|SiteContentTypeContentLink|SubSite)
    set:
      default:
        name: SiteId Default Value
        description: Get the SiteId as default to root
        script: '"root"'
```
### Versioning

``` yaml
module-version: 1.3.0
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
