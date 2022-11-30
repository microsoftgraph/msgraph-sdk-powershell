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
  - remove-path-by-operation: groups\.sites_.*Onenote$|groups\.sites\.onenote.*$|.*\.onenote\..*\.parent.*|.*\.notebooks\.section.*|.*\.sectionGroups\.section.*|.*\.sections\.pages.*|sites\..*_(Create|Get|Update|Delete)Activities$|sites\..*\.activities.*|^sites_(remove|add)$|^.*sites\.(.*_.*SourceColumn|contentTypes_.*(Base|BaseTypes|ColumnPositions)|.*_(Get|Create|Update|Delete)Activities|.*\.activities.*|termStore_ListSets|termStore\.groups\.sets(\.children.*|_.*ParentGroup|\.relations_.*|\.terms\.relations_.*|\.terms\.children.*|\.terms_.*Set)|termStore\.sets(\.children.*|_.*ParentGroup|\.parentGroup.*|\.relations.*|\.terms\.children.*|\.terms\.relations.*|\.terms_.*Set))$
# Remove cmdlets
  - where:
      verb: Remove|New
      subject: ^Site$
    remove: true
# Rename cmdlets
  - where:
      verb: Get
      subject: ^Site$
      variant: ^Get1$|^GetViaIdentity1$|^Get3$|^GetViaIdentity3$|^List1$|^List3$
    set:
      subject: SubSite
  - where:
      verb: Get
      subject: ^(Site)OnenoteNotebook(RecentNotebook$)
    set:
      subject: $1$2
  - where:
      verb: Get
      subject: ^GroupSite$
      variant: ^Get$|^GetViaIdentity$|^Get3$|^GetViaIdentity3$|^List1$|^List3$
    set:
      subject: GroupSubSite
  - where:
      verb: Get
      subject: ^(Site)(Drive)$
      variant: ^Get$|^GetViaIdentity$|^Get2$|^GetViaIdentity2$
    set:
      subject: $1Default$2
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
module-version: 1.18.0
release-notes: See https://aka.ms/GraphPowerShell-Release.
```
